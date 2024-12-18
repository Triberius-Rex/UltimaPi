
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
	public class GateRattanWallRoofAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {9395, 2, -1, 0}, {9390, 1, 1, 0}, {9394, 2, 0, 0}// 1	2	3	
			, {9389, 2, 1, 0}, {9391, 0, 1, 0}, {9392, -1, 1, 0}// 4	5	6	
			, {9393, -2, 1, 0}// 7	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new GateRattanWallRoofAddonDeed();
			}
		}

		[ Constructable ]
		public GateRattanWallRoofAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public GateRattanWallRoofAddon( Serial serial ) : base( serial )
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

	public class GateRattanWallRoofAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new GateRattanWallRoofAddon();
			}
		}

		[Constructable]
		public GateRattanWallRoofAddonDeed()
		{
			Name = "GateRattanWallRoof";
		}

		public GateRattanWallRoofAddonDeed( Serial serial ) : base( serial )
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