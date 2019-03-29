//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebSite.Configuration
{
    
    
    /// <summary>
    /// The WebSite Configuration Section.
    /// </summary>
    public partial class WebSite : global::System.Configuration.ConfigurationSection
    {
        
        #region Singleton Instance
        /// <summary>
        /// The XML name of the WebSite Configuration Section.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        internal const string WebSiteSectionName = "website";
        
        /// <summary>
        /// The XML path of the WebSite Configuration Section.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        internal const string WebSiteSectionPath = "website";
        
        /// <summary>
        /// Gets the WebSite instance.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        public static global::WebSite.Configuration.WebSite Instance
        {
            get
            {
                return ((global::WebSite.Configuration.WebSite)(global::System.Configuration.ConfigurationManager.GetSection(global::WebSite.Configuration.WebSite.WebSiteSectionPath)));
            }
        }
        #endregion
        
        #region Xmlns Property
        /// <summary>
        /// The XML name of the <see cref="Xmlns"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        internal const string XmlnsPropertyName = "xmlns";
        
        /// <summary>
        /// Gets the XML namespace of this Configuration Section.
        /// </summary>
        /// <remarks>
        /// This property makes sure that if the configuration file contains the XML namespace,
        /// the parser doesn't throw an exception because it encounters the unknown "xmlns" attribute.
        /// </remarks>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::WebSite.Configuration.WebSite.XmlnsPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public string Xmlns
        {
            get
            {
                return ((string)(base[global::WebSite.Configuration.WebSite.XmlnsPropertyName]));
            }
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region Name Property
        /// <summary>
        /// The XML name of the <see cref="Name"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        internal const string NamePropertyName = "name";
        
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        [global::System.ComponentModel.DescriptionAttribute("The Name.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::WebSite.Configuration.WebSite.NamePropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual string Name
        {
            get
            {
                return ((string)(base[global::WebSite.Configuration.WebSite.NamePropertyName]));
            }
            set
            {
                base[global::WebSite.Configuration.WebSite.NamePropertyName] = value;
            }
        }
        #endregion
        
        #region Tag Property
        /// <summary>
        /// The XML name of the <see cref="Tag"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        internal const string TagPropertyName = "tag";
        
        /// <summary>
        /// Gets or sets the Tag.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        [global::System.ComponentModel.DescriptionAttribute("The Tag.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::WebSite.Configuration.WebSite.TagPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual string Tag
        {
            get
            {
                return ((string)(base[global::WebSite.Configuration.WebSite.TagPropertyName]));
            }
            set
            {
                base[global::WebSite.Configuration.WebSite.TagPropertyName] = value;
            }
        }
        #endregion
        
        #region Container Property
        /// <summary>
        /// The XML name of the <see cref="Container"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        internal const string ContainerPropertyName = "container";
        
        /// <summary>
        /// Gets or sets the Container.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        [global::System.ComponentModel.DescriptionAttribute("The Container.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::WebSite.Configuration.WebSite.ContainerPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual global::WebSite.Configuration.ContainerInfo Container
        {
            get
            {
                return ((global::WebSite.Configuration.ContainerInfo)(base[global::WebSite.Configuration.WebSite.ContainerPropertyName]));
            }
            set
            {
                base[global::WebSite.Configuration.WebSite.ContainerPropertyName] = value;
            }
        }
        #endregion
        
        #region ExternalLinks Property
        /// <summary>
        /// The XML name of the <see cref="ExternalLinks"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        internal const string ExternalLinksPropertyName = "externalLinks";
        
        /// <summary>
        /// Gets or sets the ExternalLinks.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        [global::System.ComponentModel.DescriptionAttribute("The ExternalLinks.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::WebSite.Configuration.WebSite.ExternalLinksPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual global::WebSite.Configuration.ExternalLinkCollection ExternalLinks
        {
            get
            {
                return ((global::WebSite.Configuration.ExternalLinkCollection)(base[global::WebSite.Configuration.WebSite.ExternalLinksPropertyName]));
            }
            set
            {
                base[global::WebSite.Configuration.WebSite.ExternalLinksPropertyName] = value;
            }
        }
        #endregion
    }
}
namespace WebSite.Configuration
{
    
    
    /// <summary>
    /// A collection of ExternalLink instances.
    /// </summary>
    [global::System.Configuration.ConfigurationCollectionAttribute(typeof(global::WebSite.Configuration.ExternalLink), CollectionType=global::System.Configuration.ConfigurationElementCollectionType.BasicMapAlternate, AddItemName=global::WebSite.Configuration.ExternalLinkCollection.ExternalLinkPropertyName)]
    public partial class ExternalLinkCollection : global::System.Configuration.ConfigurationElementCollection
    {
        
        #region Constants
        /// <summary>
        /// The XML name of the individual <see cref="global::WebSite.Configuration.ExternalLink"/> instances in this collection.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        internal const string ExternalLinkPropertyName = "link";
        #endregion
        
        #region Overrides
        /// <summary>
        /// Gets the type of the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <returns>The <see cref="global::System.Configuration.ConfigurationElementCollectionType"/> of this collection.</returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        public override global::System.Configuration.ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return global::System.Configuration.ConfigurationElementCollectionType.BasicMapAlternate;
            }
        }
        
        /// <summary>
        /// Gets the name used to identify this collection of elements
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        protected override string ElementName
        {
            get
            {
                return global::WebSite.Configuration.ExternalLinkCollection.ExternalLinkPropertyName;
            }
        }
        
        /// <summary>
        /// Indicates whether the specified <see cref="global::System.Configuration.ConfigurationElement"/> exists in the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="elementName">The name of the element to verify.</param>
        /// <returns>
        /// <see langword="true"/> if the element exists in the collection; otherwise, <see langword="false"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        protected override bool IsElementName(string elementName)
        {
            return (elementName == global::WebSite.Configuration.ExternalLinkCollection.ExternalLinkPropertyName);
        }
        
        /// <summary>
        /// Gets the element key for the specified configuration element.
        /// </summary>
        /// <param name="element">The <see cref="global::System.Configuration.ConfigurationElement"/> to return the key for.</param>
        /// <returns>
        /// An <see cref="object"/> that acts as the key for the specified <see cref="global::System.Configuration.ConfigurationElement"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        protected override object GetElementKey(global::System.Configuration.ConfigurationElement element)
        {
            return ((global::WebSite.Configuration.ExternalLink)(element)).Name;
        }
        
        /// <summary>
        /// Creates a new <see cref="global::WebSite.Configuration.ExternalLink"/>.
        /// </summary>
        /// <returns>
        /// A new <see cref="global::WebSite.Configuration.ExternalLink"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        protected override global::System.Configuration.ConfigurationElement CreateNewElement()
        {
            return new global::WebSite.Configuration.ExternalLink();
        }
        #endregion
        
        #region Indexer
        /// <summary>
        /// Gets the <see cref="global::WebSite.Configuration.ExternalLink"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the <see cref="global::WebSite.Configuration.ExternalLink"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        public global::WebSite.Configuration.ExternalLink this[int index]
        {
            get
            {
                return ((global::WebSite.Configuration.ExternalLink)(base.BaseGet(index)));
            }
        }
        
        /// <summary>
        /// Gets the <see cref="global::WebSite.Configuration.ExternalLink"/> with the specified key.
        /// </summary>
        /// <param name="name">The key of the <see cref="global::WebSite.Configuration.ExternalLink"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        public global::WebSite.Configuration.ExternalLink this[object name]
        {
            get
            {
                return ((global::WebSite.Configuration.ExternalLink)(base.BaseGet(name)));
            }
        }
        #endregion
        
        #region Add
        /// <summary>
        /// Adds the specified <see cref="global::WebSite.Configuration.ExternalLink"/> to the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="link">The <see cref="global::WebSite.Configuration.ExternalLink"/> to add.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        public void Add(global::WebSite.Configuration.ExternalLink link)
        {
            base.BaseAdd(link);
        }
        #endregion
        
        #region Remove
        /// <summary>
        /// Removes the specified <see cref="global::WebSite.Configuration.ExternalLink"/> from the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="link">The <see cref="global::WebSite.Configuration.ExternalLink"/> to remove.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        public void Remove(global::WebSite.Configuration.ExternalLink link)
        {
            base.BaseRemove(this.GetElementKey(link));
        }
        #endregion
        
        #region GetItem
        /// <summary>
        /// Gets the <see cref="global::WebSite.Configuration.ExternalLink"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the <see cref="global::WebSite.Configuration.ExternalLink"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        public global::WebSite.Configuration.ExternalLink GetItemAt(int index)
        {
            return ((global::WebSite.Configuration.ExternalLink)(base.BaseGet(index)));
        }
        
        /// <summary>
        /// Gets the <see cref="global::WebSite.Configuration.ExternalLink"/> with the specified key.
        /// </summary>
        /// <param name="name">The key of the <see cref="global::WebSite.Configuration.ExternalLink"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        public global::WebSite.Configuration.ExternalLink GetItemByKey(string name)
        {
            return ((global::WebSite.Configuration.ExternalLink)(base.BaseGet(((object)(name)))));
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
    }
}
namespace WebSite.Configuration
{
    
    
    /// <summary>
    /// The ContainerInfo Configuration Element.
    /// </summary>
    public partial class ContainerInfo : global::System.Configuration.ConfigurationElement
    {
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region Name Property
        /// <summary>
        /// The XML name of the <see cref="Name"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        internal const string NamePropertyName = "name";
        
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        [global::System.ComponentModel.DescriptionAttribute("The Name.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::WebSite.Configuration.ContainerInfo.NamePropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual string Name
        {
            get
            {
                return ((string)(base[global::WebSite.Configuration.ContainerInfo.NamePropertyName]));
            }
            set
            {
                base[global::WebSite.Configuration.ContainerInfo.NamePropertyName] = value;
            }
        }
        #endregion
    }
}
namespace WebSite.Configuration
{
    
    
    /// <summary>
    /// The ExternalLink Configuration Element.
    /// </summary>
    public partial class ExternalLink : global::System.Configuration.ConfigurationElement
    {
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region Name Property
        /// <summary>
        /// The XML name of the <see cref="Name"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        internal const string NamePropertyName = "name";
        
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        [global::System.ComponentModel.DescriptionAttribute("The Name.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::WebSite.Configuration.ExternalLink.NamePropertyName, IsRequired=true, IsKey=true, IsDefaultCollection=false)]
        public virtual string Name
        {
            get
            {
                return ((string)(base[global::WebSite.Configuration.ExternalLink.NamePropertyName]));
            }
            set
            {
                base[global::WebSite.Configuration.ExternalLink.NamePropertyName] = value;
            }
        }
        #endregion
        
        #region Url Property
        /// <summary>
        /// The XML name of the <see cref="Url"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        internal const string UrlPropertyName = "url";
        
        /// <summary>
        /// Gets or sets the Url.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.801")]
        [global::System.ComponentModel.DescriptionAttribute("The Url.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::WebSite.Configuration.ExternalLink.UrlPropertyName, IsRequired=true, IsKey=false, IsDefaultCollection=false)]
        public virtual string Url
        {
            get
            {
                return ((string)(base[global::WebSite.Configuration.ExternalLink.UrlPropertyName]));
            }
            set
            {
                base[global::WebSite.Configuration.ExternalLink.UrlPropertyName] = value;
            }
        }
        #endregion
    }
}
