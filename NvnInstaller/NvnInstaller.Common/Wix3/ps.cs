﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
// 
namespace Wix3.Ps {

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/wix/PSExtension")]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/wix/PSExtension", IsNullable = false)]
  public partial class FormatsFile {

    private string fileIdField;

    private string snapInField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FileId {
      get {
        return this.fileIdField;
      }
      set {
        this.fileIdField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SnapIn {
      get {
        return this.snapInField;
      }
      set {
        this.snapInField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/wix/PSExtension")]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/wix/PSExtension", IsNullable = false)]
  public partial class TypesFile {

    private string fileIdField;

    private string snapInField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FileId {
      get {
        return this.fileIdField;
      }
      set {
        this.fileIdField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SnapIn {
      get {
        return this.snapInField;
      }
      set {
        this.snapInField = value;
      }
    }
  }

  /// <remarks/>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/wix/PSExtension")]
  [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/wix/PSExtension", IsNullable = false)]
  public partial class SnapIn {

    private object[] itemsField;

    private string idField;

    private string assemblyNameField;

    private string customSnapInTypeField;

    private string descriptionField;

    private string descriptionIndirectField;

    private string requiredPowerShellVersionField;

    private string vendorField;

    private string vendorIndirectField;

    private string versionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("FormatsFile", typeof(FormatsFile))]
    [System.Xml.Serialization.XmlElementAttribute("TypesFile", typeof(TypesFile))]
    public object[] Items {
      get {
        return this.itemsField;
      }
      set {
        this.itemsField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Id {
      get {
        return this.idField;
      }
      set {
        this.idField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string AssemblyName {
      get {
        return this.assemblyNameField;
      }
      set {
        this.assemblyNameField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CustomSnapInType {
      get {
        return this.customSnapInTypeField;
      }
      set {
        this.customSnapInTypeField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Description {
      get {
        return this.descriptionField;
      }
      set {
        this.descriptionField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DescriptionIndirect {
      get {
        return this.descriptionIndirectField;
      }
      set {
        this.descriptionIndirectField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string RequiredPowerShellVersion {
      get {
        return this.requiredPowerShellVersionField;
      }
      set {
        this.requiredPowerShellVersionField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Vendor {
      get {
        return this.vendorField;
      }
      set {
        this.vendorField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string VendorIndirect {
      get {
        return this.vendorIndirectField;
      }
      set {
        this.vendorIndirectField = value;
      }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Version {
      get {
        return this.versionField;
      }
      set {
        this.versionField = value;
      }
    }
  }
}