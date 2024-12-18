
////////////////////////////////////////
//                                     //
//   Generated by CEO's YAAAG - Ver 2  //
// (Yet Another Arya Addon Generator)  //
//    Modified by Hammerhand for       //
//      SA & High Seas content         //
//                                     //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class TwoStorySarcophagusRackEastAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {9246, 0, 2, 57}, {4310, 0, 3, 1}, {6884, 0, 3, 1}// 3	6	7	
			, {1040, 1, 4, 1}, {1035, 0, 4, 1}, {1037, 1, 3, 1}// 10	11	12	
			, {1037, 1, 2, 1}, {12794, 0, 3, 1}, {52, 0, -4, 1}// 13	14	30	
			, {52, 0, -4, 26}, {9244, 0, 1, 56}, {9245, 0, -3, 56}// 31	34	35	
			, {4311, 1, -4, 1}, {1042, 1, -4, 1}, {1038, 0, -4, 1}// 36	38	39	
			, {1037, 1, 1, 1}, {1037, 1, 0, 1}, {1037, 1, -1, 1}// 40	41	42	
			, {1037, 1, -2, 1}, {1037, 1, -3, 1}, {12792, 0, 0, 1}// 43	44	45	
			, {12794, 0, -1, 1}, {12793, 0, 1, 1}, {12793, 0, -2, 1}// 46	47	48	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new TwoStorySarcophagusRackEastAddonDeed();
			}
		}

		[ Constructable ]
		public TwoStorySarcophagusRackEastAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 6570, 0, 4, 1, 0, 1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 2568, 1, 2, 19, 0, 8, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 51, 0, 2, 26, 2101, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 51, 0, 2, 1, 2101, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 18605, 1, 2, 0, 2102, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 17339, 1, 2, 33, 2102, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 1313, 0, 2, 26, 2101, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 1401, 0, 2, 51, 2101, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 67, -1, 2, 51, 2101, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 65, 0, 2, 46, 2101, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 53, -1, 2, 26, 2101, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 67, -1, 2, 21, 2101, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 67, -1, 2, 46, 2101, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 1401, 0, 2, 46, 2101, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 53, -1, 2, 1, 2101, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 65, 0, 2, 21, 2101, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 65, 0, 2, 51, 2101, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 1313, 0, 2, 26, 2101, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 1404, 0, 2, 21, 2101, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 2568, 1, -3, 19, 0, 8, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 17339, 1, -3, 33, 2102, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 51, 0, -3, 1, 2101, -1, "", 1);// 32
			AddComplexComponent( (BaseAddon) this, 51, 0, -3, 26, 2101, -1, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 18605, 1, -3, 0, 2102, -1, "", 1);// 37
			AddComplexComponent( (BaseAddon) this, 66, 0, -4, 51, 2101, -1, "", 1);// 49
			AddComplexComponent( (BaseAddon) this, 68, -1, -4, 51, 2101, -1, "", 1);// 50
			AddComplexComponent( (BaseAddon) this, 67, 0, -1, 51, 2101, -1, "", 1);// 51
			AddComplexComponent( (BaseAddon) this, 67, 0, 0, 51, 2101, -1, "", 1);// 52
			AddComplexComponent( (BaseAddon) this, 67, 0, 1, 51, 2101, -1, "", 1);// 53
			AddComplexComponent( (BaseAddon) this, 67, -1, -2, 51, 2101, -1, "", 1);// 54
			AddComplexComponent( (BaseAddon) this, 67, -1, -3, 51, 2101, -1, "", 1);// 55
			AddComplexComponent( (BaseAddon) this, 67, -1, -1, 51, 2101, -1, "", 1);// 56
			AddComplexComponent( (BaseAddon) this, 67, -1, 0, 51, 2101, -1, "", 1);// 57
			AddComplexComponent( (BaseAddon) this, 67, -1, 1, 51, 2101, -1, "", 1);// 58
			AddComplexComponent( (BaseAddon) this, 1401, 0, 1, 51, 2101, -1, "", 1);// 59
			AddComplexComponent( (BaseAddon) this, 1401, 0, 0, 51, 2101, -1, "", 1);// 60
			AddComplexComponent( (BaseAddon) this, 1401, 0, -1, 51, 2101, -1, "", 1);// 61
			AddComplexComponent( (BaseAddon) this, 1401, 0, -2, 51, 2101, -1, "", 1);// 62
			AddComplexComponent( (BaseAddon) this, 1401, 0, -3, 51, 2101, -1, "", 1);// 63
			AddComplexComponent( (BaseAddon) this, 67, 0, -2, 46, 2101, -1, "", 1);// 64
			AddComplexComponent( (BaseAddon) this, 67, 0, -3, 46, 2101, -1, "", 1);// 65
			AddComplexComponent( (BaseAddon) this, 66, 0, -4, 46, 2101, -1, "", 1);// 66
			AddComplexComponent( (BaseAddon) this, 68, -1, -4, 46, 2101, -1, "", 1);// 67
			AddComplexComponent( (BaseAddon) this, 67, 0, -1, 46, 2101, -1, "", 1);// 68
			AddComplexComponent( (BaseAddon) this, 67, 0, 0, 46, 2101, -1, "", 1);// 69
			AddComplexComponent( (BaseAddon) this, 53, -1, -3, 26, 2101, -1, "", 1);// 70
			AddComplexComponent( (BaseAddon) this, 70, -1, 1, 26, 2101, -1, "", 1);// 71
			AddComplexComponent( (BaseAddon) this, 73, -1, -2, 26, 2101, -1, "", 1);// 72
			AddComplexComponent( (BaseAddon) this, 70, 0, 1, 26, 2101, -1, "", 1);// 73
			AddComplexComponent( (BaseAddon) this, 73, 0, -2, 26, 2101, -1, "", 1);// 74
			AddComplexComponent( (BaseAddon) this, 67, -1, 1, 21, 2101, -1, "", 1);// 75
			AddComplexComponent( (BaseAddon) this, 67, 0, -3, 21, 2101, -1, "", 1);// 76
			AddComplexComponent( (BaseAddon) this, 67, 0, -2, 21, 2101, -1, "", 1);// 77
			AddComplexComponent( (BaseAddon) this, 68, -1, -4, 21, 2101, -1, "", 1);// 78
			AddComplexComponent( (BaseAddon) this, 67, -1, 0, 21, 2101, -1, "", 1);// 79
			AddComplexComponent( (BaseAddon) this, 67, -1, -1, 21, 2101, -1, "", 1);// 80
			AddComplexComponent( (BaseAddon) this, 67, 0, 1, 21, 2101, -1, "", 1);// 81
			AddComplexComponent( (BaseAddon) this, 1401, 0, -2, 46, 2101, -1, "", 1);// 82
			AddComplexComponent( (BaseAddon) this, 1401, 0, -1, 46, 2101, -1, "", 1);// 83
			AddComplexComponent( (BaseAddon) this, 1401, 0, 0, 46, 2101, -1, "", 1);// 84
			AddComplexComponent( (BaseAddon) this, 1401, 0, 1, 46, 2101, -1, "", 1);// 85
			AddComplexComponent( (BaseAddon) this, 1404, 0, 1, 21, 2101, -1, "", 1);// 86
			AddComplexComponent( (BaseAddon) this, 73, -1, -2, 1, 2101, -1, "", 1);// 87
			AddComplexComponent( (BaseAddon) this, 73, 0, -2, 1, 2101, -1, "", 1);// 88
			AddComplexComponent( (BaseAddon) this, 70, 0, 1, 1, 2101, -1, "", 1);// 89
			AddComplexComponent( (BaseAddon) this, 1404, 0, 0, 21, 2101, -1, "", 1);// 90
			AddComplexComponent( (BaseAddon) this, 1404, 0, -1, 21, 2101, -1, "", 1);// 91
			AddComplexComponent( (BaseAddon) this, 1404, 0, -2, 21, 2101, -1, "", 1);// 92
			AddComplexComponent( (BaseAddon) this, 1404, 0, -3, 21, 2101, -1, "", 1);// 93
			AddComplexComponent( (BaseAddon) this, 67, -1, 1, 46, 2101, -1, "", 1);// 94
			AddComplexComponent( (BaseAddon) this, 67, -1, 0, 46, 2101, -1, "", 1);// 95
			AddComplexComponent( (BaseAddon) this, 67, -1, -1, 46, 2101, -1, "", 1);// 96
			AddComplexComponent( (BaseAddon) this, 67, -1, -2, 46, 2101, -1, "", 1);// 97
			AddComplexComponent( (BaseAddon) this, 67, -1, -3, 46, 2101, -1, "", 1);// 98
			AddComplexComponent( (BaseAddon) this, 67, 0, 1, 46, 2101, -1, "", 1);// 99
			AddComplexComponent( (BaseAddon) this, 66, 0, -4, 21, 2101, -1, "", 1);// 100
			AddComplexComponent( (BaseAddon) this, 67, -1, -2, 21, 2101, -1, "", 1);// 101
			AddComplexComponent( (BaseAddon) this, 70, -1, 1, 1, 2101, -1, "", 1);// 102
			AddComplexComponent( (BaseAddon) this, 1313, 0, -2, 26, 2101, -1, "", 1);// 103
			AddComplexComponent( (BaseAddon) this, 1313, 0, -1, 26, 2101, -1, "", 1);// 104
			AddComplexComponent( (BaseAddon) this, 1313, 0, 0, 26, 2101, -1, "", 1);// 105
			AddComplexComponent( (BaseAddon) this, 67, 0, -3, 51, 2101, -1, "", 1);// 106
			AddComplexComponent( (BaseAddon) this, 1313, 0, 1, 26, 2101, -1, "", 1);// 107
			AddComplexComponent( (BaseAddon) this, 1401, 0, -3, 46, 2101, -1, "", 1);// 108
			AddComplexComponent( (BaseAddon) this, 67, 0, -2, 51, 2101, -1, "", 1);// 109
			AddComplexComponent( (BaseAddon) this, 67, -1, -3, 21, 2101, -1, "", 1);// 110
			AddComplexComponent( (BaseAddon) this, 67, 0, 0, 21, 2101, -1, "", 1);// 111
			AddComplexComponent( (BaseAddon) this, 67, 0, -1, 21, 2101, -1, "", 1);// 112
			AddComplexComponent( (BaseAddon) this, 1313, 0, -3, 26, 2101, -1, "", 1);// 113

		}

		public TwoStorySarcophagusRackEastAddon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
        }

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class TwoStorySarcophagusRackEastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new TwoStorySarcophagusRackEastAddon();
			}
		}

		[Constructable]
		public TwoStorySarcophagusRackEastAddonDeed()
		{
			Name = "TwoStorySarcophagusRackEast";
		}

		public TwoStorySarcophagusRackEastAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}