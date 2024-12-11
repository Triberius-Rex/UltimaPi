
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
	public class TENT5x10NoHueAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2778, 1, -2, 2}, {2778, 0, -2, 2}, {2778, -1, -2, 2}// 1	2	3	
			, {2783, -2, -2, 2}, {2785, 2, -2, 2}, {2786, -1, -1, 2}// 4	5	6	
			, {2781, -2, -1, 2}, {2786, 0, -1, 2}, {2786, 1, -1, 2}// 7	8	9	
			, {2779, 2, -1, 2}, {15773, 0, 5, 1}, {15773, -1, 5, 1}// 10	11	12	
			, {15775, 4, 5, 10}, {15775, 4, 4, 10}, {15775, 4, 3, 10}// 13	14	15	
			, {15775, 4, 2, 10}, {15775, 4, 1, 10}, {15775, 4, 0, 10}// 16	17	18	
			, {15775, 4, -1, 10}, {15775, 4, -2, 10}, {15772, 3, 6, 10}// 19	20	21	
			, {15772, 2, 6, 10}, {15772, 1, 6, 10}, {15772, 0, 6, 10}// 22	23	24	
			, {15772, -1, 6, 10}, {15774, 3, -2, 1}, {15774, 3, 0, 1}// 25	26	27	
			, {15774, 3, -1, 1}, {1652, 0, -2, 26}, {1652, 0, 2, 26}// 28	29	30	
			, {1652, 0, 1, 26}, {1652, 0, 0, 26}, {1652, 0, -1, 26}// 31	32	33	
			, {1651, 1, 2, 26}, {1651, 1, 1, 26}, {1651, 1, 0, 26}// 34	35	36	
			, {1651, 1, -1, 26}, {1651, 1, -2, 26}, {1638, 0, 3, 26}// 37	38	39	
			, {1635, 1, 3, 26}, {1635, 2, 4, 23}, {1638, -1, 4, 23}// 40	41	42	
			, {1632, 0, 4, 23}, {1632, 1, 4, 23}, {1630, -1, 3, 23}// 43	44	45	
			, {1630, -1, 2, 23}, {1630, -1, 1, 23}, {1630, -1, 0, 23}// 46	47	48	
			, {1630, -1, -1, 23}, {1630, -1, -2, 23}, {1633, 2, -2, 23}// 49	50	51	
			, {1633, 2, -1, 23}, {1633, 2, 0, 23}, {1633, 2, 1, 23}// 52	53	54	
			, {1633, 2, 2, 23}, {1633, 2, 3, 23}, {1645, 3, 5, 20}// 55	56	57	
			, {1648, -2, 5, 20}, {1611, 2, 5, 20}, {1611, 1, 5, 20}// 58	59	60	
			, {1611, 0, 5, 20}, {1611, -1, 5, 20}, {1642, -2, 4, 20}// 61	62	63	
			, {1642, -2, 3, 20}, {1642, -2, 2, 20}, {1642, -2, 1, 20}// 64	65	66	
			, {1642, -2, 0, 20}, {1642, -2, -1, 20}, {1642, -2, -2, 20}// 67	68	69	
			, {1644, 3, 4, 20}, {1644, 3, 3, 20}, {1644, 3, 2, 20}// 70	71	72	
			, {1644, 3, 1, 20}, {1644, 3, 0, 20}, {1644, 3, -1, 20}// 73	74	75	
			, {1644, 3, -2, 20}, {39631, 2, 4, 20}, {39631, 2, 3, 20}// 76	77	78	
			, {39631, 2, 2, 20}, {39631, 2, 1, 20}, {39631, 2, 0, 20}// 79	80	81	
			, {39631, 2, -1, 20}, {39631, 2, -2, 20}, {39631, 1, 4, 20}// 82	83	84	
			, {39631, 1, 3, 20}, {39631, 1, 2, 20}, {39631, 1, 1, 20}// 85	86	87	
			, {39631, 1, 0, 20}, {39631, 1, -1, 20}, {39631, 1, -2, 20}// 88	89	90	
			, {39631, 0, 4, 20}, {39631, 0, 3, 20}, {39631, 0, 2, 20}// 91	92	93	
			, {39631, 0, 1, 20}, {39631, 0, 0, 20}, {39631, 0, -1, 20}// 94	95	96	
			, {39631, 0, -2, 20}, {39631, -1, 4, 20}, {39631, -1, 3, 20}// 97	98	99	
			, {39631, -1, 2, 20}, {39631, -1, 1, 20}, {39631, -1, 0, 20}// 100	101	102	
			, {39631, -1, -1, 20}, {39631, -1, -2, 20}, {39631, -2, 4, 20}// 103	104	105	
			, {39631, -2, 3, 20}, {39631, -2, 2, 20}, {39631, -2, 1, 20}// 106	107	108	
			, {39631, -2, 0, 20}, {39631, -2, -1, 20}, {39631, -2, -2, 20}// 109	110	111	
			, {744, 3, 5, 1}, {742, -3, -2, 1}, {742, -3, 0, 1}// 112	113	114	
			, {742, -3, 1, 1}, {742, -3, 2, 1}, {742, -3, -1, 1}// 115	116	117	
			, {742, -3, 3, 1}, {742, -3, 4, 1}, {745, -2, 5, 1}// 118	119	120	
			, {745, -1, 5, 1}, {745, 1, 5, 1}, {745, 2, 5, 1}// 121	122	123	
			, {746, 3, 4, 1}, {746, 3, 3, 1}, {746, 3, 2, 1}// 124	125	126	
			, {746, 3, 1, 1}, {746, 3, -2, 1}, {2778, 1, -3, 2}// 127	128	129	
			, {2778, 0, -3, 2}, {2778, -1, -3, 2}, {2783, -2, -3, 2}// 130	131	132	
			, {2785, 2, -3, 2}, {2778, 1, -4, 2}, {2778, 0, -4, 2}// 133	134	135	
			, {2778, -1, -4, 2}, {2780, -2, -5, 2}, {2785, 2, -4, 2}// 136	137	138	
			, {2784, -1, -5, 2}, {2784, 0, -5, 2}, {2784, 1, -5, 2}// 139	140	141	
			, {2783, -2, -4, 2}, {2782, 2, -5, 2}, {15775, 4, -3, 10}// 142	143	144	
			, {15775, 4, -4, 10}, {1636, 1, -3, 26}, {1637, 0, -3, 26}// 145	146	147	
			, {1637, -1, -4, 23}, {1636, 2, -4, 23}, {1631, 1, -4, 23}// 148	149	150	
			, {1631, 0, -4, 23}, {1630, -1, -3, 23}, {1633, 2, -3, 23}// 151	152	153	
			, {1647, 3, -5, 20}, {1646, -2, -5, 20}, {1642, -2, -3, 20}// 154	155	156	
			, {1642, -2, -4, 20}, {1644, 3, -3, 20}, {1644, 3, -4, 20}// 157	158	159	
			, {1643, 2, -5, 20}, {1643, 1, -5, 20}, {1643, 0, -5, 20}// 160	161	162	
			, {1643, -1, -5, 20}, {39631, 2, -3, 20}, {39631, 2, -4, 20}// 163	164	165	
			, {39631, 2, -5, 20}, {39631, 1, -3, 20}, {39631, 1, -4, 20}// 166	167	168	
			, {39631, 1, -5, 20}, {39631, 0, -3, 20}, {39631, 0, -4, 20}// 169	170	171	
			, {39631, 0, -5, 20}, {39631, -1, -3, 20}, {39631, -1, -4, 20}// 172	173	174	
			, {39631, -1, -5, 20}, {39631, -2, -3, 20}, {39631, -2, -4, 20}// 175	176	177	
			, {39631, -2, -5, 20}, {737, -3, -6, 0}, {742, -3, -5, 1}// 178	179	180	
			, {743, 2, -6, 1}, {743, 1, -6, 1}, {743, 0, -6, 1}// 181	182	183	
			, {743, -2, -6, 1}, {743, -1, -6, 1}, {748, 3, -6, 1}// 184	185	186	
			, {742, -3, -4, 1}, {742, -3, -3, 1}, {746, 3, -3, 1}// 187	188	189	
			, {746, 3, -4, 1}, {746, 3, -5, 1}// 190	191	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new TENT5x10NoHueAddonDeed();
			}
		}

		[ Constructable ]
		public TENT5x10NoHueAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public TENT5x10NoHueAddon( Serial serial ) : base( serial )
		{
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

	public class TENT5x10NoHueAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new TENT5x10NoHueAddon();
			}
		}

		[Constructable]
		public TENT5x10NoHueAddonDeed()
		{
			Name = "TENT5x10NoHue";
		}

		public TENT5x10NoHueAddonDeed( Serial serial ) : base( serial )
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