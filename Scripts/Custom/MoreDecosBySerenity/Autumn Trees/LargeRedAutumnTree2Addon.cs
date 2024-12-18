
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
	public class LargeRedAutumnTree2Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {42589, 3, 0, 31}, {42591, 1, 0, 58}, {42598, 1, 2, 0}// 2	3	4	
			, {42598, 2, -1, 0}, {42598, -1, 2, 0}, {42598, 0, -2, 0}// 5	6	7	
			, {42591, -1, 2, 29}, {42593, 1, 0, 31}, {42589, 0, 1, 23}// 9	10	11	
			, {42594, 2, 0, 42}, {42594, -1, 2, 41}, {42591, 2, 3, 76}// 12	13	14	
			, {3441, 1, -1, 0}// 16	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new LargeRedAutumnTree2AddonDeed();
			}
		}

		[ Constructable ]
		public LargeRedAutumnTree2Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 3387, 0, -1, 11, 2418, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 42598, -2, 0, 0, 2418, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 3439, -1, 1, 0, 2418, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 3440, 0, 0, 0, 2418, -1, "", 1);// 17

		}

		public LargeRedAutumnTree2Addon( Serial serial ) : base( serial )
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

	public class LargeRedAutumnTree2AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new LargeRedAutumnTree2Addon();
			}
		}

		[Constructable]
		public LargeRedAutumnTree2AddonDeed()
		{
			Name = "LargeRedAutumnTree2";
		}

		public LargeRedAutumnTree2AddonDeed( Serial serial ) : base( serial )
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