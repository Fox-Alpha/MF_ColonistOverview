// using System.Xml.Serialization;
// XmlSerializer serializer = new XmlSerializer(typeof(SaveGame));
// using (StringReader reader = new StringReader(xml))
// {
//    var test = (SaveGame)serializer.Deserialize(reader);
// }

[XmlRoot(ElementName="job")]
public class Job { 

	[XmlAttribute(AttributeName="id")] 
	public string Id { get; set; } 

	[XmlAttribute(AttributeName="xp")] 
	public int Xp { get; set; } 

	[XmlAttribute(AttributeName="idx")] 
	public int Idx { get; set; } 
}

[XmlRoot(ElementName="attr")]
public class Attr { 

	[XmlElement(ElementName="a_effect")] 
	public List<AEffect> AEffect { get; set; } 

	[XmlAttribute(AttributeName="id")] 
	public string Id { get; set; } 

	[XmlAttribute(AttributeName="cv")] 
	public double Cv { get; set; } 
}

[XmlRoot(ElementName="a_effect")]
public class AEffect { 

	[XmlAttribute(AttributeName="id")] 
	public string Id { get; set; } 

	[XmlAttribute(AttributeName="stack")] 
	public int Stack { get; set; } 

	[XmlAttribute(AttributeName="expires")] 
	public double Expires { get; set; } 
}

[XmlRoot(ElementName="cmp")]
public class Cmp { 

	[XmlElement(ElementName="eq")] 
	public List<Eq> Eq { get; set; } 

	[XmlAttribute(AttributeName="tn")] 
	public string Tn { get; set; } 

	[XmlAttribute(AttributeName="iid")] 
	public int Iid { get; set; } 

	[XmlText] 
	public string Text { get; set; } 

	[XmlElement(ElementName="boarded")] 
	public bool Boarded { get; set; } 

	[XmlElement(ElementName="v_id")] 
	public int VId { get; set; } 

	[XmlElement(ElementName="quirk")] 
	public List<Quirk> Quirk { get; set; } 

	[XmlElement(ElementName="attr")] 
	public List<Attr> Attr { get; set; } 

	[XmlElement(ElementName="max_items")] 
	public int MaxItems { get; set; } 

	[XmlElement(ElementName="global")] 
	public bool Global { get; set; } 

	[XmlElement(ElementName="priority")] 
	public int Priority { get; set; } 

	[XmlElement(ElementName="inv")] 
	public Inv Inv { get; set; } 
}

[XmlRoot(ElementName="inv")]
public class Inv { 

	[XmlAttribute(AttributeName="iotype")] 
	public int Iotype { get; set; } 

	[XmlElement(ElementName="inv_item")] 
	public List<InvItem> InvItem { get; set; } 
}

[XmlRoot(ElementName="eq")]
public class Eq { 

	[XmlAttribute(AttributeName="idx")] 
	public int Idx { get; set; } 

	[XmlAttribute(AttributeName="wfi")] 
	public bool Wfi { get; set; } 

	[XmlText] 
	public string Text { get; set; } 
}

[XmlRoot(ElementName="c")]
public class C { 

	[XmlElement(ElementName="px")] 
	public int Px { get; set; } 

	[XmlElement(ElementName="py")] 
	public double Py { get; set; } 

	[XmlElement(ElementName="color")] 
	public string Color { get; set; } 

	[XmlElement(ElementName="hcolor")] 
	public string Hcolor { get; set; } 

	[XmlElement(ElementName="acc_ids")] 
	public object AccIds { get; set; } 

	[XmlElement(ElementName="cn")] 
	public string Cn { get; set; } 

	[XmlElement(ElementName="age")] 
	public int Age { get; set; } 

	[XmlElement(ElementName="dead")] 
	public bool Dead { get; set; } 

	[XmlElement(ElementName="outfit_color_1")] 
	public string OutfitColor1 { get; set; } 

	[XmlElement(ElementName="outfit_color_2")] 
	public string OutfitColor2 { get; set; } 

	[XmlElement(ElementName="job")] 
	public List<Job> Job { get; set; } 

	[XmlElement(ElementName="cmp")] 
	public List<Cmp> Cmp { get; set; } 

	[XmlAttribute(AttributeName="id")] 
	public string Id { get; set; } 

	[XmlAttribute(AttributeName="iid")] 
	public int Iid { get; set; } 

	[XmlText] 
	public string Text { get; set; } 

	[XmlElement(ElementName="outfit_color_3")] 
	public string OutfitColor3 { get; set; } 
}

[XmlRoot(ElementName="quirk")]
public class Quirk { 

	[XmlElement(ElementName="item_id")] 
	public string ItemId { get; set; } 

	[XmlAttribute(AttributeName="id")] 
	public string Id { get; set; } 

	[XmlText] 
	public string Text { get; set; } 
}

[XmlRoot(ElementName="inv_item")]
public class InvItem { 

	[XmlAttribute(AttributeName="n")] 
	public string N { get; set; } 

	[XmlAttribute(AttributeName="qty")] 
	public int Qty { get; set; } 
}

[XmlRoot(ElementName="colonists")]
public class Colonists { 

	[XmlElement(ElementName="c")] 
	public List<C> C { get; set; } 
}

[XmlRoot(ElementName="cs")]
public class Cs { 

	[XmlElement(ElementName="colonists")] 
	public string Colonists { get; set; } 

	[XmlElement(ElementName="hours")] 
	public string Hours { get; set; } 

	[XmlAttribute(AttributeName="n")] 
	public string N { get; set; } 

	[XmlText] 
	public string Text { get; set; } 
}

[XmlRoot(ElementName="colonist_schedules")]
public class ColonistSchedules { 

	[XmlElement(ElementName="cs")] 
	public List<Cs> Cs { get; set; } 
}

[XmlRoot(ElementName="mgr")]
public class Mgr { 

	[XmlElement(ElementName="colonists")] 
	public Colonists Colonists { get; set; } 

	[XmlElement(ElementName="colonist_schedules")] 
	public ColonistSchedules ColonistSchedules { get; set; } 

	[XmlAttribute(AttributeName="id")] 
	public string Id { get; set; } 

	[XmlText] 
	public string Text { get; set; } 
}

[XmlRoot(ElementName="managers")]
public class Managers { 

	[XmlElement(ElementName="mgr")] 
	public Mgr Mgr { get; set; } 
}

[XmlRoot(ElementName="SaveGame")]
public class SaveGame { 

	[XmlElement(ElementName="managers")] 
	public Managers Managers { get; set; } 

	[XmlAttribute(AttributeName="name")] 
	public string Name { get; set; } 

	[XmlAttribute(AttributeName="ts")] 
	public int Ts { get; set; } 

	[XmlAttribute(AttributeName="ver")] 
	public int Ver { get; set; } 

	[XmlAttribute(AttributeName="bnum")] 
	public int Bnum { get; set; } 

	[XmlText] 
	public string Text { get; set; } 
}

