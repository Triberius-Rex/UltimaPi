
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
	public class BlueFairyShopAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {4800, 8, -12, 120}, {4799, 7, -11, 120}, {4798, 6, -10, 120}// 7	8	9	
			, {5453, -5, 6, 5}, {9269, 0, 7, 0}, {9269, 0, 6, 0}// 10	11	12	
			, {9269, -1, 7, 0}, {9269, -1, 6, 0}, {9269, -1, 5, 0}// 16	17	18	
			, {9269, -1, 4, 0}, {9269, -1, 3, 0}, {9269, -1, 2, 0}// 19	20	21	
			, {9269, -2, 6, 0}, {9269, -2, 5, 0}, {9269, -2, 4, 0}// 23	24	25	
			, {9269, -2, 3, 0}, {9269, -2, 2, 0}, {9269, -3, 6, 0}// 26	27	29	
			, {9269, -3, 5, 0}, {9269, -3, 4, 0}, {9269, -3, 3, 0}// 30	31	32	
			, {9269, -3, 2, 0}, {9269, -4, 6, 0}, {9269, -4, 5, 0}// 33	35	36	
			, {9269, -4, 4, 0}, {9269, -4, 3, 0}, {9269, -4, 2, 0}// 37	38	39	
			, {9269, -5, 6, 0}, {9269, -5, 5, 0}, {9269, -5, 4, 0}// 40	41	42	
			, {9269, -5, 3, 0}, {9269, -5, 2, 0}, {9269, -6, 4, 0}// 43	44	45	
			, {9269, -6, 3, 0}, {9269, -2, 1, 0}, {9269, -3, 1, 0}// 46	97	98	
			, {9269, -4, 1, 0}// 100	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new BlueFairyShopAddonDeed();
			}
		}

		[ Constructable ]
		public BlueFairyShopAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 487, 2, 5, 0, 1336, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 4803, 2, 8, 32, 1156, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 4804, 3, 7, 32, 1156, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 4805, 4, 6, 32, 1156, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 4806, 5, 5, 32, 1156, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 4807, 6, 4, 32, 1156, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 9269, 0, 5, 0, 1153, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 9269, 0, 4, 0, 1153, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 9269, 0, 3, 0, 1153, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 9269, -2, 7, 0, 1153, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 9269, -3, 7, 0, 1153, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 9269, -4, 7, 0, 1153, -1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 9269, -6, 2, 0, 1153, -1, "", 1);// 47
			AddComplexComponent( (BaseAddon) this, 9269, -7, 4, 0, 1153, -1, "", 1);// 48
			AddComplexComponent( (BaseAddon) this, 9269, -7, 3, 0, 1153, -1, "", 1);// 49
			AddComplexComponent( (BaseAddon) this, 9269, -7, 2, 0, 1153, -1, "", 1);// 50
			AddComplexComponent( (BaseAddon) this, 9269, 0, 5, 0, 1153, -1, "", 1);// 51
			AddComplexComponent( (BaseAddon) this, 9269, 0, 4, 0, 1153, -1, "", 1);// 52
			AddComplexComponent( (BaseAddon) this, 9269, 0, 3, 0, 1153, -1, "", 1);// 53
			AddComplexComponent( (BaseAddon) this, 9269, -6, 2, 0, 1153, -1, "", 1);// 54
			AddComplexComponent( (BaseAddon) this, 9269, -7, 4, 0, 1153, -1, "", 1);// 55
			AddComplexComponent( (BaseAddon) this, 9269, -7, 3, 0, 1153, -1, "", 1);// 56
			AddComplexComponent( (BaseAddon) this, 9269, -7, 2, 0, 1153, -1, "", 1);// 57
			AddComplexComponent( (BaseAddon) this, 9269, -3, 7, 0, 1153, -1, "", 1);// 58
			AddComplexComponent( (BaseAddon) this, 9269, -4, 7, 0, 1153, -1, "", 1);// 59
			AddComplexComponent( (BaseAddon) this, 486, -2, 9, 0, 1336, -1, "", 1);// 60
			AddComplexComponent( (BaseAddon) this, 9553, 1, 3, 0, 1336, -1, "", 1);// 61
			AddComplexComponent( (BaseAddon) this, 9539, 1, 6, 0, 1336, -1, "", 1);// 62
			AddComplexComponent( (BaseAddon) this, 4802, 1, 9, 32, 1156, -1, "", 1);// 63
			AddComplexComponent( (BaseAddon) this, 4801, 0, 10, 32, 1156, -1, "", 1);// 64
			AddComplexComponent( (BaseAddon) this, 4800, -1, 11, 32, 1156, -1, "", 1);// 65
			AddComplexComponent( (BaseAddon) this, 4799, -2, 12, 32, 1156, -1, "", 1);// 66
			AddComplexComponent( (BaseAddon) this, 4798, -3, 13, 32, 1156, -1, "", 1);// 67
			AddComplexComponent( (BaseAddon) this, 16134, 0, 7, 20, 1336, -1, "", 1);// 68
			AddComplexComponent( (BaseAddon) this, 9539, 1, 6, 20, 1336, -1, "", 1);// 69
			AddComplexComponent( (BaseAddon) this, 9553, 1, 5, 20, 1336, -1, "", 1);// 70
			AddComplexComponent( (BaseAddon) this, 9539, 1, 4, 20, 1336, -1, "", 1);// 71
			AddComplexComponent( (BaseAddon) this, 9553, 1, 3, 20, 1336, -1, "", 1);// 72
			AddComplexComponent( (BaseAddon) this, 9548, -2, 8, 20, 1336, -1, "", 1);// 73
			AddComplexComponent( (BaseAddon) this, 9544, -1, 8, 20, 1336, -1, "", 1);// 74
			AddComplexComponent( (BaseAddon) this, 9555, 0, 2, 20, 1336, -1, "", 1);// 75
			AddComplexComponent( (BaseAddon) this, 9544, -3, 8, 20, 1336, -1, "", 1);// 76
			AddComplexComponent( (BaseAddon) this, 9548, -4, 8, 20, 1336, -1, "", 1);// 77
			AddComplexComponent( (BaseAddon) this, 9555, -5, 7, 20, 1336, -1, "", 1);// 78
			AddComplexComponent( (BaseAddon) this, 9546, -6, 6, 20, 1336, -1, "", 1);// 79
			AddComplexComponent( (BaseAddon) this, 9536, -6, 5, 20, 1336, -1, "", 1);// 80
			AddComplexComponent( (BaseAddon) this, 9546, -6, 4, 20, 1336, -1, "", 1);// 81
			AddComplexComponent( (BaseAddon) this, 9536, -6, 3, 20, 1336, -1, "", 1);// 82
			AddComplexComponent( (BaseAddon) this, 16134, -5, 2, 20, 1336, -1, "", 1);// 83
			AddComplexComponent( (BaseAddon) this, 9553, 1, 5, 0, 1336, -1, "", 1);// 84
			AddComplexComponent( (BaseAddon) this, 9539, 1, 4, 0, 1336, -1, "", 1);// 85
			AddComplexComponent( (BaseAddon) this, 9544, -1, 8, 0, 1336, -1, "", 1);// 86
			AddComplexComponent( (BaseAddon) this, 9548, -2, 8, 0, 1336, -1, "", 1);// 87
			AddComplexComponent( (BaseAddon) this, 9544, -3, 8, 0, 1336, -1, "", 1);// 88
			AddComplexComponent( (BaseAddon) this, 9548, -4, 8, 0, 1336, -1, "", 1);// 89
			AddComplexComponent( (BaseAddon) this, 9555, 0, 2, 0, 1336, -1, "", 1);// 90
			AddComplexComponent( (BaseAddon) this, 9555, -5, 7, 0, 1336, -1, "", 1);// 91
			AddComplexComponent( (BaseAddon) this, 9546, -6, 6, 0, 1336, -1, "", 1);// 92
			AddComplexComponent( (BaseAddon) this, 9536, -6, 5, 0, 1336, -1, "", 1);// 93
			AddComplexComponent( (BaseAddon) this, 9546, -6, 4, 0, 1336, -1, "", 1);// 94
			AddComplexComponent( (BaseAddon) this, 9536, -6, 3, 0, 1336, -1, "", 1);// 95
			AddComplexComponent( (BaseAddon) this, 9541, -5, 2, 0, 1336, -1, "", 1);// 96
			AddComplexComponent( (BaseAddon) this, 9269, -3, 0, 0, 1153, -1, "", 1);// 99
			AddComplexComponent( (BaseAddon) this, 9269, -4, 0, 0, 1153, -1, "", 1);// 101
			AddComplexComponent( (BaseAddon) this, 9269, -5, 1, 0, 1153, -1, "", 1);// 102
			AddComplexComponent( (BaseAddon) this, 9269, -5, 0, 0, 1153, -1, "", 1);// 103
			AddComplexComponent( (BaseAddon) this, 9269, -6, 1, 0, 1153, -1, "", 1);// 104
			AddComplexComponent( (BaseAddon) this, 9269, -6, 0, 0, 1153, -1, "", 1);// 105
			AddComplexComponent( (BaseAddon) this, 9269, -7, 1, 0, 1153, -1, "", 1);// 106
			AddComplexComponent( (BaseAddon) this, 9269, -3, 0, 0, 1153, -1, "", 1);// 107
			AddComplexComponent( (BaseAddon) this, 9269, -4, 0, 0, 1153, -1, "", 1);// 108
			AddComplexComponent( (BaseAddon) this, 9551, -1, 1, 20, 1336, -1, "", 1);// 109
			AddComplexComponent( (BaseAddon) this, 9537, -2, 1, 20, 1336, -1, "", 1);// 110
			AddComplexComponent( (BaseAddon) this, 9551, -3, 1, 20, 1336, -1, "", 1);// 111
			AddComplexComponent( (BaseAddon) this, 9537, -4, 1, 20, 1336, -1, "", 1);// 112
			AddComplexComponent( (BaseAddon) this, 9551, -1, 1, 0, 1336, -1, "", 1);// 113
			AddComplexComponent( (BaseAddon) this, 9537, -2, 1, 0, 1336, -1, "", 1);// 114
			AddComplexComponent( (BaseAddon) this, 9551, -3, 1, 0, 1336, -1, "", 1);// 115
			AddComplexComponent( (BaseAddon) this, 9537, -4, 1, 0, 1336, -1, "", 1);// 116

		}

		public BlueFairyShopAddon( Serial serial ) : base( serial )
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

	public class BlueFairyShopAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new BlueFairyShopAddon();
			}
		}

		[Constructable]
		public BlueFairyShopAddonDeed()
		{
			Name = "BlueFairyShop";
		}

		public BlueFairyShopAddonDeed( Serial serial ) : base( serial )
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