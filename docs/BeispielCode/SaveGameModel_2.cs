   /* 
    Licensed under the Apache License, Version 2.0
    
    http://www.apache.org/licenses/LICENSE-2.0
    */
using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace Xml2CSharp
{
	[XmlRoot(ElementName="job")]
	public class Job {
		[XmlAttribute(AttributeName="id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName="xp")]
		public string Xp { get; set; }
		[XmlAttribute(AttributeName="idx")]
		public string Idx { get; set; }
	}

	[XmlRoot(ElementName="attr")]
	public class Attr {
		[XmlAttribute(AttributeName="id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName="cv")]
		public string Cv { get; set; }
		[XmlElement(ElementName="a_effect")]
		public List<A_effect> A_effect { get; set; }
	}

	[XmlRoot(ElementName="a_effect")]
	public class A_effect {
		[XmlAttribute(AttributeName="id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName="stack")]
		public string Stack { get; set; }
		[XmlAttribute(AttributeName="expires")]
		public string Expires { get; set; }
	}

	[XmlRoot(ElementName="cmp")]
	public class Cmp {
		[XmlElement(ElementName="attr")]
		public List<Attr> Attr { get; set; }
		[XmlAttribute(AttributeName="tn")]
		public string Tn { get; set; }
		[XmlAttribute(AttributeName="iid")]
		public string Iid { get; set; }
		[XmlElement(ElementName="max_items")]
		public string Max_items { get; set; }
		[XmlElement(ElementName="global")]
		public string Global { get; set; }
		[XmlElement(ElementName="priority")]
		public string Priority { get; set; }
		[XmlElement(ElementName="inv")]
		public Inv Inv { get; set; }
		[XmlElement(ElementName="eq")]
		public List<Eq> Eq { get; set; }
		[XmlElement(ElementName="boarded")]
		public string Boarded { get; set; }
		[XmlElement(ElementName="v_id")]
		public string V_id { get; set; }
		[XmlElement(ElementName="quirk")]
		public List<Quirk> Quirk { get; set; }
	}

	[XmlRoot(ElementName="inv")]
	public class Inv {
		[XmlAttribute(AttributeName="iotype")]
		public string Iotype { get; set; }
		[XmlElement(ElementName="inv_item")]
		public List<Inv_item> Inv_item { get; set; }
	}

	[XmlRoot(ElementName="eq")]
	public class Eq {
		[XmlAttribute(AttributeName="idx")]
		public string Idx { get; set; }
		[XmlAttribute(AttributeName="wfi")]
		public string Wfi { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName="c")]
	public class C {
		[XmlElement(ElementName="px")]
		public string Px { get; set; }
		[XmlElement(ElementName="py")]
		public string Py { get; set; }
		[XmlElement(ElementName="color")]
		public string Color { get; set; }
		[XmlElement(ElementName="hcolor")]
		public string Hcolor { get; set; }
		[XmlElement(ElementName="acc_ids")]
		public string Acc_ids { get; set; }
		[XmlElement(ElementName="cn")]
		public string Cn { get; set; }
		[XmlElement(ElementName="age")]
		public string Age { get; set; }
		[XmlElement(ElementName="dead")]
		public string Dead { get; set; }
		[XmlElement(ElementName="outfit_color_1")]
		public string Outfit_color_1 { get; set; }
		[XmlElement(ElementName="outfit_color_2")]
		public string Outfit_color_2 { get; set; }
		[XmlElement(ElementName="job")]
		public List<Job> Job { get; set; }
		[XmlElement(ElementName="cmp")]
		public List<Cmp> Cmp { get; set; }
		[XmlAttribute(AttributeName="id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName="iid")]
		public string Iid { get; set; }
		[XmlElement(ElementName="outfit_color_3")]
		public string Outfit_color_3 { get; set; }
	}

	[XmlRoot(ElementName="quirk")]
	public class Quirk {
		[XmlElement(ElementName="item_id")]
		public string Item_id { get; set; }
		[XmlAttribute(AttributeName="id")]
		public string Id { get; set; }
	}

	[XmlRoot(ElementName="inv_item")]
	public class Inv_item {
		[XmlAttribute(AttributeName="n")]
		public string N { get; set; }
		[XmlAttribute(AttributeName="qty")]
		public string Qty { get; set; }
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
	}

	[XmlRoot(ElementName="colonist_schedules")]
	public class Colonist_schedules {
		[XmlElement(ElementName="cs")]
		public List<Cs> Cs { get; set; }
	}

	[XmlRoot(ElementName="mgr")]
	public class Mgr {
		[XmlElement(ElementName="colonists")]
		public Colonists Colonists { get; set; }
		[XmlElement(ElementName="colonist_schedules")]
		public Colonist_schedules Colonist_schedules { get; set; }
		[XmlAttribute(AttributeName="id")]
		public string Id { get; set; }
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
		public string Ts { get; set; }
		[XmlAttribute(AttributeName="ver")]
		public string Ver { get; set; }
		[XmlAttribute(AttributeName="bnum")]
		public string Bnum { get; set; }
	}

}
