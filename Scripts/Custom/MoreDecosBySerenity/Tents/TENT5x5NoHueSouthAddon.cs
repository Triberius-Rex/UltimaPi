
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
	public class TENT5x5NoHueSouthAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2879, 1, -2, 3}, {2778, 1, 1, 2}, {2778, 1, 0, 2}// 1	2	3	
			, {2778, 1, -1, 2}, {2778, 0, -1, 2}, {2778, 0, 0, 2}// 4	5	6	
			, {2778, 0, 1, 2}, {2785, 2, -1, 2}, {2784, 0, -2, 2}// 7	8	9	
			, {2784, 1, -2, 2}, {2782, 2, -2, 2}, {2786, 0, 2, 2}// 10	11	12	
			, {2786, 1, 2, 2}, {2785, 2, 0, 2}, {2785, 2, 1, 2}// 13	14	15	
			, {2779, 2, 2, 2}, {15775, 4, -1, 10}, {15775, 4, 0, 10}// 16	17	18	
			, {15775, 4, 1, 10}, {15775, 4, 2, 10}, {15775, 4, 3, 10}// 19	20	21	
			, {15772, 0, 4, 10}, {15772, 3, 4, 10}, {15772, 2, 4, 10}// 22	23	24	
			, {15772, 1, 4, 10}, {15777, 0, 3, 1}, {1638, 0, 1, 26}// 25	26	27	
			, {1635, 1, 1, 26}, {1637, 0, 0, 26}, {1636, 1, 0, 26}// 28	29	30	
			, {1636, 2, -1, 23}, {1635, 2, 2, 23}, {1632, 1, 2, 23}// 31	32	33	
			, {1632, 0, 2, 23}, {1631, 1, -1, 23}, {1631, 0, -1, 23}// 34	35	36	
			, {1633, 2, 1, 23}, {1633, 2, 0, 23}, {1645, 3, 3, 20}// 37	38	39	
			, {1647, 3, -2, 20}, {1611, 2, 3, 20}, {1611, 1, 3, 20}// 40	41	42	
			, {1611, 0, 3, 20}, {1644, 3, 2, 20}, {1644, 3, 1, 20}// 43	44	45	
			, {1644, 3, 0, 20}, {1644, 3, -1, 20}, {1643, 2, -2, 20}// 46	47	48	
			, {1643, 1, -2, 20}, {1643, 0, -2, 20}, {39631, 2, 2, 20}// 49	50	51	
			, {39631, 2, 1, 20}, {39631, 2, 0, 20}, {39631, 2, -1, 20}// 52	53	54	
			, {39631, 2, -2, 20}, {39631, 1, 2, 20}, {39631, 1, 1, 20}// 55	56	57	
			, {39631, 1, 0, 20}, {39631, 1, -1, 20}, {39631, 1, -2, 20}// 58	59	60	
			, {39631, 0, 2, 20}, {39631, 0, 1, 20}, {39631, 0, 0, 20}// 61	62	63	
			, {39631, 0, -1, 20}, {39631, 0, -2, 20}, {743, 2, -3, 1}// 64	65	66	
			, {743, 1, -3, 1}, {743, 0, -3, 1}, {748, 3, -3, 1}// 67	68	69	
			, {744, 3, 3, 1}, {745, 1, 3, 1}, {745, 2, 3, 1}// 70	71	72	
			, {746, 3, 2, 1}, {746, 3, 1, 1}, {746, 3, 0, 1}// 73	74	75	
			, {746, 3, -1, 1}, {746, 3, -2, 1}, {2658, -1, -2, 3}// 76	77	78	
			, {2653, -2, -2, 3}, {2778, -1, 1, 2}, {2778, -1, 0, 2}// 79	80	81	
			, {2778, -1, -1, 2}, {2780, -2, -2, 2}, {2784, -1, -2, 2}// 82	83	84	
			, {2783, -2, -1, 2}, {2783, -2, 0, 2}, {2783, -2, 1, 2}// 85	86	87	
			, {2786, -1, 2, 2}, {2781, -2, 2, 2}, {15772, -1, 4, 10}// 88	89	90	
			, {15777, -1, 3, 1}, {1637, -1, -1, 23}, {1638, -1, 2, 23}// 91	92	93	
			, {1630, -1, 1, 23}, {1630, -1, 0, 23}, {1648, -2, 3, 20}// 94	95	96	
			, {1646, -2, -2, 20}, {1611, -1, 3, 20}, {1642, -2, 2, 20}// 97	98	99	
			, {1642, -2, 1, 20}, {1642, -2, 0, 20}, {1642, -2, -1, 20}// 100	101	102	
			, {1643, -1, -2, 20}, {39631, -1, 2, 20}, {39631, -1, 1, 20}// 103	104	105	
			, {39631, -1, 0, 20}, {39631, -1, -1, 20}, {39631, -1, -2, 20}// 106	107	108	
			, {39631, -2, 2, 20}, {39631, -2, 1, 20}, {39631, -2, 0, 20}// 109	110	111	
			, {39631, -2, -1, 20}, {39631, -2, -2, 20}, {737, -3, -3, 0}// 112	113	114	
			, {743, -1, -3, 1}, {743, -2, -3, 1}, {742, -3, 2, 1}// 115	116	117	
			, {742, -3, -1, 1}, {742, -3, -2, 1}, {742, -3, 0, 1}// 118	119	120	
			, {742, -3, 1, 1}, {745, -2, 3, 1}, {745, -1, 3, 1}// 121	122	123	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new TENT5x5NoHueSouthAddonDeed();
			}
		}

		[ Constructable ]
		public TENT5x5NoHueSouthAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public TENT5x5NoHueSouthAddon( Serial serial ) : base( serial )
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

	public class TENT5x5NoHueSouthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new TENT5x5NoHueSouthAddon();
			}
		}

		[Constructable]
		public TENT5x5NoHueSouthAddonDeed()
		{
			Name = "TENT5x5NoHueSouth";
		}

		public TENT5x5NoHueSouthAddonDeed( Serial serial ) : base( serial )
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