﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class boardgames {
    
    private boardgamesBoardgame[] boardgameField;
    
    private string termsofuseField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("boardgame", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public boardgamesBoardgame[] boardgame {
        get {
            return this.boardgameField;
        }
        set {
            this.boardgameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string termsofuse {
        get {
            return this.termsofuseField;
        }
        set {
            this.termsofuseField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class boardgamesBoardgame {
    
    private string yearpublishedField;
    
    private string minplayersField;
    
    private string maxplayersField;
    
    private string playingtimeField;
    
    private string minplaytimeField;
    
    private string maxplaytimeField;
    
    private string ageField;
    
    private string descriptionField;
    
    private string thumbnailField;
    
    private string imageField;
    
    private boardgamesBoardgameName[] nameField;
    
    private boardgamesBoardgameBoardgamepublisher[] boardgamepublisherField;
    
    private boardgamesBoardgameBoardgamepodcastepisode[] boardgamepodcastepisodeField;
    
    private boardgamesBoardgameBoardgamehonor[] boardgamehonorField;
    
    private boardgamesBoardgameBoardgamefamily[] boardgamefamilyField;
    
    private boardgamesBoardgameBoardgamemechanic[] boardgamemechanicField;
    
    private boardgamesBoardgameBoardgamecategory[] boardgamecategoryField;
    
    private boardgamesBoardgameBoardgamedesigner[] boardgamedesignerField;
    
    private boardgamesBoardgameBoardgameversion[] boardgameversionField;
    
    private boardgamesBoardgameBoardgamesubdomain[] boardgamesubdomainField;
    
    private boardgamesBoardgameBoardgameartist[] boardgameartistField;
    
    private boardgamesBoardgameCardset[] cardsetField;
    
    private boardgamesBoardgamePoll[] pollField;
    
    private string objectidField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string yearpublished {
        get {
            return this.yearpublishedField;
        }
        set {
            this.yearpublishedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string minplayers {
        get {
            return this.minplayersField;
        }
        set {
            this.minplayersField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string maxplayers {
        get {
            return this.maxplayersField;
        }
        set {
            this.maxplayersField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string playingtime {
        get {
            return this.playingtimeField;
        }
        set {
            this.playingtimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string minplaytime {
        get {
            return this.minplaytimeField;
        }
        set {
            this.minplaytimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string maxplaytime {
        get {
            return this.maxplaytimeField;
        }
        set {
            this.maxplaytimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string age {
        get {
            return this.ageField;
        }
        set {
            this.ageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string thumbnail {
        get {
            return this.thumbnailField;
        }
        set {
            this.thumbnailField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string image {
        get {
            return this.imageField;
        }
        set {
            this.imageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("name", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public boardgamesBoardgameName[] name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("boardgamepublisher", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public boardgamesBoardgameBoardgamepublisher[] boardgamepublisher {
        get {
            return this.boardgamepublisherField;
        }
        set {
            this.boardgamepublisherField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("boardgamepodcastepisode", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public boardgamesBoardgameBoardgamepodcastepisode[] boardgamepodcastepisode {
        get {
            return this.boardgamepodcastepisodeField;
        }
        set {
            this.boardgamepodcastepisodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("boardgamehonor", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public boardgamesBoardgameBoardgamehonor[] boardgamehonor {
        get {
            return this.boardgamehonorField;
        }
        set {
            this.boardgamehonorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("boardgamefamily", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public boardgamesBoardgameBoardgamefamily[] boardgamefamily {
        get {
            return this.boardgamefamilyField;
        }
        set {
            this.boardgamefamilyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("boardgamemechanic", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public boardgamesBoardgameBoardgamemechanic[] boardgamemechanic {
        get {
            return this.boardgamemechanicField;
        }
        set {
            this.boardgamemechanicField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("boardgamecategory", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public boardgamesBoardgameBoardgamecategory[] boardgamecategory {
        get {
            return this.boardgamecategoryField;
        }
        set {
            this.boardgamecategoryField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("boardgamedesigner", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public boardgamesBoardgameBoardgamedesigner[] boardgamedesigner {
        get {
            return this.boardgamedesignerField;
        }
        set {
            this.boardgamedesignerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("boardgameversion", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public boardgamesBoardgameBoardgameversion[] boardgameversion {
        get {
            return this.boardgameversionField;
        }
        set {
            this.boardgameversionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("boardgamesubdomain", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public boardgamesBoardgameBoardgamesubdomain[] boardgamesubdomain {
        get {
            return this.boardgamesubdomainField;
        }
        set {
            this.boardgamesubdomainField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("boardgameartist", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public boardgamesBoardgameBoardgameartist[] boardgameartist {
        get {
            return this.boardgameartistField;
        }
        set {
            this.boardgameartistField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("cardset", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
    public boardgamesBoardgameCardset[] cardset {
        get {
            return this.cardsetField;
        }
        set {
            this.cardsetField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("poll", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public boardgamesBoardgamePoll[] poll {
        get {
            return this.pollField;
        }
        set {
            this.pollField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string objectid {
        get {
            return this.objectidField;
        }
        set {
            this.objectidField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class boardgamesBoardgameName {
    
    private string primaryField;
    
    private string sortindexField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string primary {
        get {
            return this.primaryField;
        }
        set {
            this.primaryField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string sortindex {
        get {
            return this.sortindexField;
        }
        set {
            this.sortindexField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class boardgamesBoardgameBoardgamepublisher {
    
    private string objectidField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string objectid {
        get {
            return this.objectidField;
        }
        set {
            this.objectidField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class boardgamesBoardgameBoardgamepodcastepisode {
    
    private string objectidField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string objectid {
        get {
            return this.objectidField;
        }
        set {
            this.objectidField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class boardgamesBoardgameBoardgamehonor {
    
    private string objectidField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string objectid {
        get {
            return this.objectidField;
        }
        set {
            this.objectidField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class boardgamesBoardgameBoardgamefamily {
    
    private string objectidField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string objectid {
        get {
            return this.objectidField;
        }
        set {
            this.objectidField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class boardgamesBoardgameBoardgamemechanic {
    
    private string objectidField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string objectid {
        get {
            return this.objectidField;
        }
        set {
            this.objectidField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class boardgamesBoardgameBoardgamecategory {
    
    private string objectidField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string objectid {
        get {
            return this.objectidField;
        }
        set {
            this.objectidField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class boardgamesBoardgameBoardgamedesigner {
    
    private string objectidField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string objectid {
        get {
            return this.objectidField;
        }
        set {
            this.objectidField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class boardgamesBoardgameBoardgameversion {
    
    private string objectidField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string objectid {
        get {
            return this.objectidField;
        }
        set {
            this.objectidField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class boardgamesBoardgameBoardgamesubdomain {
    
    private string objectidField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string objectid {
        get {
            return this.objectidField;
        }
        set {
            this.objectidField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class boardgamesBoardgameBoardgameartist {
    
    private string objectidField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string objectid {
        get {
            return this.objectidField;
        }
        set {
            this.objectidField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class boardgamesBoardgameCardset {
    
    private string objectidField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string objectid {
        get {
            return this.objectidField;
        }
        set {
            this.objectidField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class boardgamesBoardgamePoll {
    
    private boardgamesBoardgamePollResults[] resultsField;
    
    private string nameField;
    
    private string titleField;
    
    private string totalvotesField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("results", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public boardgamesBoardgamePollResults[] results {
        get {
            return this.resultsField;
        }
        set {
            this.resultsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string title {
        get {
            return this.titleField;
        }
        set {
            this.titleField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string totalvotes {
        get {
            return this.totalvotesField;
        }
        set {
            this.totalvotesField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class boardgamesBoardgamePollResults {
    
    private boardgamesBoardgamePollResultsResult[] resultField;
    
    private string numplayersField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("result", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public boardgamesBoardgamePollResultsResult[] result {
        get {
            return this.resultField;
        }
        set {
            this.resultField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string numplayers {
        get {
            return this.numplayersField;
        }
        set {
            this.numplayersField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class boardgamesBoardgamePollResultsResult {
    
    private string valueField;
    
    private string numvotesField;
    
    private string levelField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string numvotes {
        get {
            return this.numvotesField;
        }
        set {
            this.numvotesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string level {
        get {
            return this.levelField;
        }
        set {
            this.levelField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class NewDataSet {
    
    private boardgames[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("boardgames")]
    public boardgames[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}