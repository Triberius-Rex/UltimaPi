
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
	public class InnSideStableAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {3380, 4, 2, 41}, {42600, 2, 1, 8}, {42597, 3, 2, 35}// 1	2	3	
			, {41986, 4, 0, 37}, {41375, 4, 0, 33}, {41374, 3, 2, 33}// 4	5	6	
			, {1289, 3, -1, 29}, {1289, 2, -1, 29}, {1289, 1, -1, 29}// 7	8	9	
			, {1289, 3, 1, 29}, {1289, 2, 1, 29}, {1289, 1, 1, 29}// 10	11	12	
			, {3312, 4, 0, 6}, {3311, 4, 1, 5}, {3311, 4, -1, 5}// 14	15	16	
			, {1448, 3, 0, 32}, {1448, 2, 0, 32}, {1448, 1, 0, 32}// 17	18	19	
			, {1449, 3, -1, 28}, {1449, 2, -1, 28}, {1449, 1, -1, 28}// 20	21	22	
			, {1447, 3, 1, 29}, {1447, 2, 1, 29}, {1447, 1, 1, 29}// 23	24	25	
			, {2168, 3, 1, 18}, {5352, 4, 1, 4}, {2881, 4, -1, 1}// 26	27	28	
			, {2882, 4, 0, 1}, {3899, 2, 1, 6}, {3893, 3, 1, 0}// 29	30	31	
			, {3893, 1, 0, 0}, {3893, 1, -1, 0}, {3892, 3, 0, 1}// 32	33	34	
			, {3892, 2, -1, 1}, {3892, 2, 0, 1}, {3892, 2, 1, 1}// 35	36	37	
			, {2186, 2, -2, 10}, {2186, 1, -2, 10}, {2186, 2, -2, 0}// 38	39	40	
			, {2186, 1, -2, 0}, {2186, 3, -2, 0}, {2168, 3, 0, 25}// 41	42	43	
			, {2168, 3, 1, 12}, {2168, 3, 1, 7}, {2168, 3, -1, 20}// 44	45	46	
			, {2168, 3, -1, 13}, {2168, 3, -1, 6}, {2168, 3, -1, 0}// 47	48	49	
			, {2168, 3, 1, 0}, {42597, -1, 1, 46}, {41985, -3, 2, 35}// 50	51	52	
			, {41985, -3, -1, 34}, {41983, -2, 2, 34}, {1289, 0, -1, 29}// 53	54	55	
			, {1289, -1, -1, 29}, {1289, -2, -1, 29}, {1289, -3, -1, 29}// 56	57	58	
			, {1289, -4, -1, 29}, {1289, 0, 1, 29}, {1289, -1, 1, 29}// 59	60	61	
			, {1289, -2, 1, 29}, {1289, -3, 1, 29}, {1289, -4, 1, 29}// 62	63	64	
			, {1448, 0, 0, 32}, {1448, -1, 0, 32}, {1448, -2, 0, 32}// 66	67	68	
			, {1448, -3, 0, 32}, {1448, -4, 0, 32}, {1449, 0, -1, 28}// 69	70	71	
			, {1449, -1, -1, 28}, {1449, -2, -1, 28}, {1449, -3, -1, 28}// 72	73	74	
			, {1449, -4, -1, 28}, {1447, 0, 1, 29}, {1447, -1, 1, 29}// 75	76	77	
			, {1447, -2, 1, 29}, {1447, -3, 1, 29}, {1447, -4, 1, 29}// 78	79	80	
			, {2168, -4, 1, 19}, {5352, 0, -1, 3}, {2187, -1, 0, 2}// 81	82	83	
			, {2187, -1, -1, 2}, {3000, -4, 2, 6}, {2976, -4, 2, 7}// 84	85	86	
			, {4022, -2, 2, 1}, {3894, -3, 1, 3}, {3894, -3, 0, 5}// 87	88	89	
			, {3893, 0, -1, 0}, {3893, -1, 0, 0}, {3893, -2, 1, 0}// 90	91	92	
			, {3892, -3, 1, 1}, {3892, -1, -1, 1}, {3892, -2, 0, 1}// 93	94	95	
			, {3892, -3, 0, 1}, {3892, -2, -1, 1}, {41726, -2, -1, 5}// 96	97	98	
			, {2186, 0, -2, 10}, {2186, -1, -2, 10}, {2186, -2, -2, 10}// 99	100	101	
			, {2186, -3, -2, 10}, {2186, 0, -2, 0}, {2186, -1, -2, 0}// 102	103	104	
			, {2186, -2, -2, 0}, {2186, -3, -2, 0}, {2168, -4, 0, 26}// 105	106	107	
			, {2168, -4, -1, 18}, {2168, -4, 1, 12}, {2168, -4, -1, 12}// 108	109	110	
			, {2168, -4, 1, 6}, {2168, -4, -1, 6}, {2168, -4, 1, 0}// 111	112	113	
			, {2168, -4, -1, 0}// 114	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new InnSideStableAddonDeed();
			}
		}

		[ Constructable ]
		public InnSideStableAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 2586, 4, 0, 23, 0, 1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 2586, -3, 0, 23, 0, 1, "", 1);// 65

		}

		public InnSideStableAddon( Serial serial ) : base( serial )
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

	public class InnSideStableAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new InnSideStableAddon();
			}
		}

		[Constructable]
		public InnSideStableAddonDeed()
		{
			Name = "InnSideStable";
		}

		public InnSideStableAddonDeed( Serial serial ) : base( serial )
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