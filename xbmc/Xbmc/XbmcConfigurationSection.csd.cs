//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Xbmc
{
    
    
    /// <summary>
    /// The XbmcConfigurationSection Configuration Section.
    /// </summary>
    public partial class XbmcConfigurationSection : global::System.Configuration.ConfigurationSection
    {
        
        #region Singleton Instance
        /// <summary>
        /// The XML name of the XbmcConfigurationSection Configuration Section.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string XbmcConfigurationSectionSectionName = "xbmcConfigurationSection";
        
        /// <summary>
        /// Gets the XbmcConfigurationSection instance.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        public static global::Xbmc.XbmcConfigurationSection Instance
        {
            get
            {
                return ((global::Xbmc.XbmcConfigurationSection)(global::System.Configuration.ConfigurationManager.GetSection(global::Xbmc.XbmcConfigurationSection.XbmcConfigurationSectionSectionName)));
            }
        }
        #endregion
        
        #region Xmlns Property
        /// <summary>
        /// The XML name of the <see cref="Xmlns"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string XmlnsPropertyName = "xmlns";
        
        /// <summary>
        /// Gets the XML namespace of this Configuration Section.
        /// </summary>
        /// <remarks>
        /// This property makes sure that if the configuration file contains the XML namespace,
        /// the parser doesn't throw an exception because it encounters the unknown "xmlns" attribute.
        /// </remarks>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Xbmc.XbmcConfigurationSection.XmlnsPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public string Xmlns
        {
            get
            {
                return ((string)(base[global::Xbmc.XbmcConfigurationSection.XmlnsPropertyName]));
            }
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region Hosts Property
        /// <summary>
        /// The XML name of the <see cref="Hosts"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string HostsPropertyName = "hosts";
        
        /// <summary>
        /// Gets or sets the Hosts.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        [global::System.ComponentModel.DescriptionAttribute("The Hosts.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Xbmc.XbmcConfigurationSection.HostsPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual global::Xbmc.XbmcHosts Hosts
        {
            get
            {
                return ((global::Xbmc.XbmcHosts)(base[global::Xbmc.XbmcConfigurationSection.HostsPropertyName]));
            }
            set
            {
                base[global::Xbmc.XbmcConfigurationSection.HostsPropertyName] = value;
            }
        }
        #endregion
    }
}
namespace Xbmc
{
    
    
    /// <summary>
    /// The XbmcHost Configuration Element.
    /// </summary>
    public partial class XbmcHost : global::System.Configuration.ConfigurationElement
    {
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region Name Property
        /// <summary>
        /// The XML name of the <see cref="Name"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string NamePropertyName = "name";
        
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        [global::System.ComponentModel.DescriptionAttribute("The Name.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Xbmc.XbmcHost.NamePropertyName, IsRequired=true, IsKey=true, IsDefaultCollection=false)]
        public virtual string Name
        {
            get
            {
                return ((string)(base[global::Xbmc.XbmcHost.NamePropertyName]));
            }
            set
            {
                base[global::Xbmc.XbmcHost.NamePropertyName] = value;
            }
        }
        #endregion
        
        #region Host Property
        /// <summary>
        /// The XML name of the <see cref="Host"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string HostPropertyName = "host";
        
        /// <summary>
        /// Gets or sets the Host.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        [global::System.ComponentModel.DescriptionAttribute("The Host.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Xbmc.XbmcHost.HostPropertyName, IsRequired=true, IsKey=false, IsDefaultCollection=false)]
        public virtual string Host
        {
            get
            {
                return ((string)(base[global::Xbmc.XbmcHost.HostPropertyName]));
            }
            set
            {
                base[global::Xbmc.XbmcHost.HostPropertyName] = value;
            }
        }
        #endregion
        
        #region Port Property
        /// <summary>
        /// The XML name of the <see cref="Port"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string PortPropertyName = "port";
        
        /// <summary>
        /// Gets or sets the Port.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        [global::System.ComponentModel.DescriptionAttribute("The Port.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Xbmc.XbmcHost.PortPropertyName, IsRequired=true, IsKey=false, IsDefaultCollection=false)]
        public virtual int Port
        {
            get
            {
                return ((int)(base[global::Xbmc.XbmcHost.PortPropertyName]));
            }
            set
            {
                base[global::Xbmc.XbmcHost.PortPropertyName] = value;
            }
        }
        #endregion
        
        #region Login Property
        /// <summary>
        /// The XML name of the <see cref="Login"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string LoginPropertyName = "login";
        
        /// <summary>
        /// Gets or sets the Login.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        [global::System.ComponentModel.DescriptionAttribute("The Login.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Xbmc.XbmcHost.LoginPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual string Login
        {
            get
            {
                return ((string)(base[global::Xbmc.XbmcHost.LoginPropertyName]));
            }
            set
            {
                base[global::Xbmc.XbmcHost.LoginPropertyName] = value;
            }
        }
        #endregion
        
        #region Password Property
        /// <summary>
        /// The XML name of the <see cref="Password"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string PasswordPropertyName = "password";
        
        /// <summary>
        /// Gets or sets the Password.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        [global::System.ComponentModel.DescriptionAttribute("The Password.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Xbmc.XbmcHost.PasswordPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual string Password
        {
            get
            {
                return ((string)(base[global::Xbmc.XbmcHost.PasswordPropertyName]));
            }
            set
            {
                base[global::Xbmc.XbmcHost.PasswordPropertyName] = value;
            }
        }
        #endregion
        
        #region Interval Property
        /// <summary>
        /// The XML name of the <see cref="Interval"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string IntervalPropertyName = "interval";
        
        /// <summary>
        /// Gets or sets the Interval.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        [global::System.ComponentModel.DescriptionAttribute("The Interval.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Xbmc.XbmcHost.IntervalPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false, DefaultValue=1000)]
        public virtual int Interval
        {
            get
            {
                return ((int)(base[global::Xbmc.XbmcHost.IntervalPropertyName]));
            }
            set
            {
                base[global::Xbmc.XbmcHost.IntervalPropertyName] = value;
            }
        }
        #endregion
    }
}
namespace Xbmc
{
    
    
    /// <summary>
    /// A collection of XbmcHost instances.
    /// </summary>
    [global::System.Configuration.ConfigurationCollectionAttribute(typeof(global::Xbmc.XbmcHost), CollectionType=global::System.Configuration.ConfigurationElementCollectionType.BasicMapAlternate, AddItemName=global::Xbmc.XbmcHosts.XbmcHostPropertyName)]
    public partial class XbmcHosts : global::System.Configuration.ConfigurationElementCollection
    {
        
        #region Constants
        /// <summary>
        /// The XML name of the individual <see cref="global::Xbmc.XbmcHost"/> instances in this collection.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string XbmcHostPropertyName = "xbmcHost";
        #endregion
        
        #region Overrides
        /// <summary>
        /// Gets the type of the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <returns>The <see cref="global::System.Configuration.ConfigurationElementCollectionType"/> of this collection.</returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        protected override string ElementName
        {
            get
            {
                return global::Xbmc.XbmcHosts.XbmcHostPropertyName;
            }
        }
        
        /// <summary>
        /// Indicates whether the specified <see cref="global::System.Configuration.ConfigurationElement"/> exists in the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="elementName">The name of the element to verify.</param>
        /// <returns>
        /// <see langword="true"/> if the element exists in the collection; otherwise, <see langword="false"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        protected override bool IsElementName(string elementName)
        {
            return (elementName == global::Xbmc.XbmcHosts.XbmcHostPropertyName);
        }
        
        /// <summary>
        /// Gets the element key for the specified configuration element.
        /// </summary>
        /// <param name="element">The <see cref="global::System.Configuration.ConfigurationElement"/> to return the key for.</param>
        /// <returns>
        /// An <see cref="object"/> that acts as the key for the specified <see cref="global::System.Configuration.ConfigurationElement"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        protected override object GetElementKey(global::System.Configuration.ConfigurationElement element)
        {
            return ((global::Xbmc.XbmcHost)(element)).Name;
        }
        
        /// <summary>
        /// Creates a new <see cref="global::Xbmc.XbmcHost"/>.
        /// </summary>
        /// <returns>
        /// A new <see cref="global::Xbmc.XbmcHost"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        protected override global::System.Configuration.ConfigurationElement CreateNewElement()
        {
            return new global::Xbmc.XbmcHost();
        }
        #endregion
        
        #region Indexer
        /// <summary>
        /// Gets the <see cref="global::Xbmc.XbmcHost"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the <see cref="global::Xbmc.XbmcHost"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        public global::Xbmc.XbmcHost this[int index]
        {
            get
            {
                return ((global::Xbmc.XbmcHost)(base.BaseGet(index)));
            }
        }
        
        /// <summary>
        /// Gets the <see cref="global::Xbmc.XbmcHost"/> with the specified key.
        /// </summary>
        /// <param name="name">The key of the <see cref="global::Xbmc.XbmcHost"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        public global::Xbmc.XbmcHost this[object name]
        {
            get
            {
                return ((global::Xbmc.XbmcHost)(base.BaseGet(name)));
            }
        }
        #endregion
        
        #region Add
        /// <summary>
        /// Adds the specified <see cref="global::Xbmc.XbmcHost"/> to the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="xbmcHost">The <see cref="global::Xbmc.XbmcHost"/> to add.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        public void Add(global::Xbmc.XbmcHost xbmcHost)
        {
            base.BaseAdd(xbmcHost);
        }
        #endregion
        
        #region Remove
        /// <summary>
        /// Removes the specified <see cref="global::Xbmc.XbmcHost"/> from the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="xbmcHost">The <see cref="global::Xbmc.XbmcHost"/> to remove.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        public void Remove(global::Xbmc.XbmcHost xbmcHost)
        {
            base.BaseRemove(this.GetElementKey(xbmcHost));
        }
        #endregion
        
        #region GetItem
        /// <summary>
        /// Gets the <see cref="global::Xbmc.XbmcHost"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the <see cref="global::Xbmc.XbmcHost"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        public global::Xbmc.XbmcHost GetItemAt(int index)
        {
            return ((global::Xbmc.XbmcHost)(base.BaseGet(index)));
        }
        
        /// <summary>
        /// Gets the <see cref="global::Xbmc.XbmcHost"/> with the specified key.
        /// </summary>
        /// <param name="name">The key of the <see cref="global::Xbmc.XbmcHost"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        public global::Xbmc.XbmcHost GetItemByKey(string name)
        {
            return ((global::Xbmc.XbmcHost)(base.BaseGet(((object)(name)))));
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
    }
}
