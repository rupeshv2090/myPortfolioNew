// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class adf
{

    private adfProspect prospectField;

    /// <remarks/>
    public adfProspect prospect
    {
        get
        {
            return this.prospectField;
        }
        set
        {
            this.prospectField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class adfProspect
{

    private adfProspectID idField;

    private System.DateTime requestdateField;

    private adfProspectCustomer customerField;

    private adfProspectProvider providerField;

    /// <remarks/>
    public adfProspectID id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    public System.DateTime requestdate
    {
        get
        {
            return this.requestdateField;
        }
        set
        {
            this.requestdateField = value;
        }
    }

    /// <remarks/>
    public adfProspectCustomer customer
    {
        get
        {
            return this.customerField;
        }
        set
        {
            this.customerField = value;
        }
    }

    /// <remarks/>
    public adfProspectProvider provider
    {
        get
        {
            return this.providerField;
        }
        set
        {
            this.providerField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class adfProspectID
{

    private byte sequenceField;

    private string sourceField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte sequence
    {
        get
        {
            return this.sequenceField;
        }
        set
        {
            this.sequenceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string source
    {
        get
        {
            return this.sourceField;
        }
        set
        {
            this.sourceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class adfProspectCustomer
{

    private adfProspectCustomerContact contactField;

    private adfProspectCustomerEvent eventField;

    private adfProspectCustomerComments commentsField;

    /// <remarks/>
    public adfProspectCustomerContact contact
    {
        get
        {
            return this.contactField;
        }
        set
        {
            this.contactField = value;
        }
    }

    /// <remarks/>
    public adfProspectCustomerEvent Event
    {
        get
        {
            return this.eventField;
        }
        set
        {
            this.eventField = value;
        }
    }

    /// <remarks/>
    public adfProspectCustomerComments comments
    {
        get
        {
            return this.commentsField;
        }
        set
        {
            this.commentsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class adfProspectCustomerContact
{

    private adfProspectCustomerContactName[] nameField;

    private adfProspectCustomerContactEmail emailField;

    private ulong phoneField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("name")]
    public adfProspectCustomerContactName[] name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public adfProspectCustomerContactEmail email
    {
        get
        {
            return this.emailField;
        }
        set
        {
            this.emailField = value;
        }
    }

    /// <remarks/>
    public ulong phone
    {
        get
        {
            return this.phoneField;
        }
        set
        {
            this.phoneField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class adfProspectCustomerContactName
{

    private string partField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string part
    {
        get
        {
            return this.partField;
        }
        set
        {
            this.partField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class adfProspectCustomerContactEmail
{

    private adfProspectCustomerContactEmailA aField;

    /// <remarks/>
    public adfProspectCustomerContactEmailA a
    {
        get
        {
            return this.aField;
        }
        set
        {
            this.aField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class adfProspectCustomerContactEmailA
{

    private string hrefField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string href
    {
        get
        {
            return this.hrefField;
        }
        set
        {
            this.hrefField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class adfProspectCustomerEvent
{

    private string eventpasscodeField;

    /// <remarks/>
    public string eventpasscode
    {
        get
        {
            return this.eventpasscodeField;
        }
        set
        {
            this.eventpasscodeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class adfProspectCustomerComments
{

    private adfProspectCustomerCommentsA aField;

    private string[] textField;

    /// <remarks/>
    public adfProspectCustomerCommentsA a
    {
        get
        {
            return this.aField;
        }
        set
        {
            this.aField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Text
    {
        get
        {
            return this.textField;
        }
        set
        {
            this.textField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class adfProspectCustomerCommentsA
{

    private string hrefField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string href
    {
        get
        {
            return this.hrefField;
        }
        set
        {
            this.hrefField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class adfProspectProvider
{

    private adfProspectProviderName nameField;

    private string serviceField;

    private adfProspectProviderUrl urlField;

    private adfProspectProviderEmail emailField;

    private adfProspectProviderContact contactField;

    /// <remarks/>
    public adfProspectProviderName name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public string service
    {
        get
        {
            return this.serviceField;
        }
        set
        {
            this.serviceField = value;
        }
    }

    /// <remarks/>
    public adfProspectProviderUrl url
    {
        get
        {
            return this.urlField;
        }
        set
        {
            this.urlField = value;
        }
    }

    /// <remarks/>
    public adfProspectProviderEmail email
    {
        get
        {
            return this.emailField;
        }
        set
        {
            this.emailField = value;
        }
    }

    /// <remarks/>
    public adfProspectProviderContact contact
    {
        get
        {
            return this.contactField;
        }
        set
        {
            this.contactField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class adfProspectProviderName
{

    private string partField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string part
    {
        get
        {
            return this.partField;
        }
        set
        {
            this.partField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class adfProspectProviderUrl
{

    private adfProspectProviderUrlA aField;

    /// <remarks/>
    public adfProspectProviderUrlA a
    {
        get
        {
            return this.aField;
        }
        set
        {
            this.aField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class adfProspectProviderUrlA
{

    private string hrefField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string href
    {
        get
        {
            return this.hrefField;
        }
        set
        {
            this.hrefField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class adfProspectProviderEmail
{

    private adfProspectProviderEmailA aField;

    /// <remarks/>
    public adfProspectProviderEmailA a
    {
        get
        {
            return this.aField;
        }
        set
        {
            this.aField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class adfProspectProviderEmailA
{

    private string hrefField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string href
    {
        get
        {
            return this.hrefField;
        }
        set
        {
            this.hrefField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class adfProspectProviderContact
{

    private adfProspectProviderContactName nameField;

    private adfProspectProviderContactEmail emailField;

    private byte primarycontactField;

    /// <remarks/>
    public adfProspectProviderContactName name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public adfProspectProviderContactEmail email
    {
        get
        {
            return this.emailField;
        }
        set
        {
            this.emailField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte primarycontact
    {
        get
        {
            return this.primarycontactField;
        }
        set
        {
            this.primarycontactField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class adfProspectProviderContactName
{

    private string partField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string part
    {
        get
        {
            return this.partField;
        }
        set
        {
            this.partField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class adfProspectProviderContactEmail
{

    private adfProspectProviderContactEmailA aField;

    /// <remarks/>
    public adfProspectProviderContactEmailA a
    {
        get
        {
            return this.aField;
        }
        set
        {
            this.aField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class adfProspectProviderContactEmailA
{

    private string hrefField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string href
    {
        get
        {
            return this.hrefField;
        }
        set
        {
            this.hrefField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

