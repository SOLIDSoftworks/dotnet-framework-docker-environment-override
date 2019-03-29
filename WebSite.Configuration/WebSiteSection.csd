<?xml version="1.0" encoding="utf-8"?>
<configurationSectionModel xmlns:dm0="http://schemas.microsoft.com/VisualStudio/2008/DslTools/Core" dslVersion="1.0.0.0" Id="35e9fb76-3510-44c3-828a-aae44a4f3311" namespace="WebSite.Configuration" xmlSchemaNamespace="urn:WebSite.Configuration" xmlns="http://schemas.microsoft.com/dsltools/ConfigurationSectionDesigner">
  <typeDefinitions>
    <externalType name="String" namespace="System" />
    <externalType name="Boolean" namespace="System" />
    <externalType name="Int32" namespace="System" />
    <externalType name="Int64" namespace="System" />
    <externalType name="Single" namespace="System" />
    <externalType name="Double" namespace="System" />
    <externalType name="DateTime" namespace="System" />
    <externalType name="TimeSpan" namespace="System" />
  </typeDefinitions>
  <configurationElements>
    <configurationSection name="WebSite" codeGenOptions="Singleton, XmlnsProperty" xmlSectionName="website">
      <attributeProperties>
        <attributeProperty name="Name" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="name" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/35e9fb76-3510-44c3-828a-aae44a4f3311/String" />
          </type>
        </attributeProperty>
        <attributeProperty name="Tag" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="tag" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/35e9fb76-3510-44c3-828a-aae44a4f3311/String" />
          </type>
        </attributeProperty>
      </attributeProperties>
      <elementProperties>
        <elementProperty name="Container" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="container" isReadOnly="false">
          <type>
            <configurationElementMoniker name="/35e9fb76-3510-44c3-828a-aae44a4f3311/ContainerInfo" />
          </type>
        </elementProperty>
        <elementProperty name="ExternalLinks" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="externalLinks" isReadOnly="false">
          <type>
            <configurationElementCollectionMoniker name="/35e9fb76-3510-44c3-828a-aae44a4f3311/ExternalLinkCollection" />
          </type>
        </elementProperty>
      </elementProperties>
    </configurationSection>
    <configurationElementCollection name="ExternalLinkCollection" xmlItemName="link" codeGenOptions="Indexer, AddMethod, RemoveMethod, GetItemMethods">
      <itemType>
        <configurationElementMoniker name="/35e9fb76-3510-44c3-828a-aae44a4f3311/ExternalLink" />
      </itemType>
    </configurationElementCollection>
    <configurationElement name="ContainerInfo">
      <attributeProperties>
        <attributeProperty name="Name" isRequired="false" isKey="false" isDefaultCollection="false" xmlName="name" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/35e9fb76-3510-44c3-828a-aae44a4f3311/String" />
          </type>
        </attributeProperty>
      </attributeProperties>
    </configurationElement>
    <configurationElement name="ExternalLink">
      <attributeProperties>
        <attributeProperty name="Name" isRequired="true" isKey="true" isDefaultCollection="false" xmlName="name" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/35e9fb76-3510-44c3-828a-aae44a4f3311/String" />
          </type>
        </attributeProperty>
        <attributeProperty name="Url" isRequired="true" isKey="false" isDefaultCollection="false" xmlName="url" isReadOnly="false">
          <type>
            <externalTypeMoniker name="/35e9fb76-3510-44c3-828a-aae44a4f3311/String" />
          </type>
        </attributeProperty>
      </attributeProperties>
    </configurationElement>
  </configurationElements>
  <propertyValidators>
    <validators />
  </propertyValidators>
</configurationSectionModel>