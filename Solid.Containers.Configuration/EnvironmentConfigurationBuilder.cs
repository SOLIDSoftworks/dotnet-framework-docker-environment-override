using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace Solid.Containers.Configuration
{
    public class EnvironmentConfigurationBuilder : ConfigurationBuilder
    {
        private const string KeyPrefix = "ASPNET";

public override XmlNode ProcessRawXml(XmlNode rawXml)
{
    if (rawXml.LocalName == "appSettings") return ProcessAppSettingsXml(rawXml);
    if (rawXml.LocalName == "connectionStrings") return ProcessConnectionStringsXml(rawXml);
    return ProcessCustomConfigurationSection(rawXml);
}

private XmlNode ProcessCustomConfigurationSection(XmlNode section)
{
    var prefix = $"{KeyPrefix}__{section.LocalName}__";
    var environment = GetEnvironmentVariables();
    var keys = environment.Keys.Where(key => key.StartsWith(prefix));
    foreach (var key in keys)
    {
        var path = ParsePath(key);
        var xml = section;
        foreach (var part in path.Item1)
        {
            var element = null as XmlElement;
            if (part.Index == null)
                element = xml[part.Name];
            else
                element = xml.ChildNodes.OfType<XmlElement>().ElementAtOrDefault(part.Index.Value);

            if (element == null)
            {
                element = xml.OwnerDocument.CreateElement(part.Name, section.NamespaceURI);
                xml.AppendChild(element);
            }

            xml = element;
        }
        var attribute = xml.Attributes[path.Item2];
        if (attribute == null)
        {
            attribute = xml.OwnerDocument.CreateAttribute(path.Item2);
            xml.Attributes.Append(attribute);
        }
        attribute.Value = environment[key];
    }
    return section;
}

private XmlNode ProcessAppSettingsXml(XmlNode appSettings)
{
    var environment = GetEnvironmentVariables();
    var settings = appSettings.ChildNodes.OfType<XmlElement>().ToDictionary(n => n.Attributes["key"].Value, n => n.Attributes["value"]);
    foreach (var variable in environment)
    {
        var prefix = $"{KeyPrefix}__appSettings__";
        if (!variable.Key.StartsWith(prefix)) continue;

        var key = variable.Key.Substring(prefix.Length);
        if (settings.ContainsKey(key))
        {
            settings[key].Value = variable.Value;
            continue;
        }
        // Add the app setting if missing from original configuration
        var element = appSettings.OwnerDocument.CreateElement("add");

        var elementKey = appSettings.OwnerDocument.CreateAttribute("key");
        elementKey.Value = key;
        element.Attributes.Append(elementKey);

        var elementValue = appSettings.OwnerDocument.CreateAttribute("value");
        elementValue.Value = variable.Value;
        element.Attributes.Append(elementValue);

        appSettings.AppendChild(element);
    }

    return appSettings;
}

private XmlNode ProcessConnectionStringsXml(XmlNode connectionStrings)
{
    var environment = GetEnvironmentVariables();
    var connections = connectionStrings.ChildNodes.OfType<XmlElement>().ToDictionary(n => n.Attributes["name"].Value, n => n.Attributes["connectionString"]);
    foreach (var variable in environment)
    {
        var prefix = $"{KeyPrefix}__connectionStrings__";
        if (!variable.Key.StartsWith(prefix)) continue;

        var name = variable.Key.Substring(prefix.Length);
                
        if (connections.ContainsKey(name))
            connections[name].Value = variable.Value;

        // Skip the connection if missing from original configuration
    }

    return connectionStrings;
}

        private Dictionary<string, string> GetEnvironmentVariables()
        {
            var environment = Environment
                   .GetEnvironmentVariables();
            var variables = environment
                .Keys
                .OfType<string>()
                .ToDictionary(k => k, k => environment[k].ToString(), StringComparer.OrdinalIgnoreCase)
                ;

            return variables;
        }

private (ElementDescription[], string) ParsePath(string key)
{
    var split = key.Split(new[] { "__" }, StringSplitOptions.RemoveEmptyEntries).Skip(2); // skip prefix and section element name
    if (split.Count() == 0) return (new ElementDescription[0], null);
    var attribute = split.LastOrDefault();
    var path = split.Take(split.Count() - 1);
    return (path.Select(Convert).ToArray(), attribute);
}

private ElementDescription Convert(string part)
{
    var regex = new Regex(@"^(.*?)\[(\d+)\]$");
    var match = regex.Match(part);
    if (!match.Success) return new ElementDescription { Name = part };

    return new ElementDescription
    {
        Index = int.Parse(match.Groups[2].Value),
        Name = match.Groups[1].Value
    };
}

class ElementDescription
{
    public int? Index { get; set; }
    public string Name { get; set; }
}
    }
}
