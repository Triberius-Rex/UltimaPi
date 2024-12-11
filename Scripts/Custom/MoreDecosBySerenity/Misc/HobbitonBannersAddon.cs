
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
	public class HobbitonBannersAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new HobbitonBannersAddonDeed();
			}
		}

		[ Constructable ]
		public HobbitonBannersAddon()
		{



			AddComplexComponent( (BaseAddon) this, 7027, 4, 0, 35, 2418, -1, "Oil Lantern", 1);// 1
			AddComplexComponent( (BaseAddon) this, 9417, 4, 0, 35, 0, 2, "Oil Lantern", 1);// 2
			AddComplexComponent( (BaseAddon) this, 43294, -2, 1, 19, 0, 1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 43294, 0, 1, 19, 0, 1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 5530, -1, 1, 19, 2128, -1, "Hobbiton Banner", 1);// 5
			AddComplexComponent( (BaseAddon) this, 43294, 2, 1, 19, 0, 1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 43294, 4, 1, 19, 0, 1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 5531, 0, 1, 19, 2128, -1, "Hobbiton Banner", 1);// 8
			AddComplexComponent( (BaseAddon) this, 5531, 1, 1, 19, 2128, -1, "Hobbiton Banner", 1);// 9
			AddComplexComponent( (BaseAddon) this, 414, -2, 0, 20, 2418, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 414, -1, 0, 20, 2418, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 157, 4, 0, 0, 2418, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 414, 0, 0, 20, 2418, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 414, 1, 0, 20, 2418, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 5521, -2, 1, 19, 2128, -1, "Hobbiton Banner", 1);// 15
			AddComplexComponent( (BaseAddon) this, 5521, 3, 1, 19, 2128, -1, "Hobbiton Banner", 1);// 16
			AddComplexComponent( (BaseAddon) this, 414, 2, 0, 20, 2418, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 411, 4, 0, 14, 2418, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 7608, 4, 0, 36, 2418, -1, "Oil Lantern", 1);// 19
			AddComplexComponent( (BaseAddon) this, 5530, 2, 1, 19, 2128, -1, "Hobbiton Banner", 1);// 20
			AddComplexComponent( (BaseAddon) this, 413, -3, 0, 20, 2418, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 415, 4, 0, 20, 2418, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 414, 3, 0, 20, 2418, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 411, -4, 0, 20, 2418, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 157, -4, 0, 0, 2418, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 7608, -4, 0, 36, 2418, -1, "Oil Lantern", 1);// 26
			AddComplexComponent( (BaseAddon) this, 411, -4, 0, 14, 2418, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 9417, -4, 0, 35, 0, 2, "Oil Lantern", 1);// 28

		}

		public HobbitonBannersAddon( Serial serial ) : base( serial )
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

	public class HobbitonBannersAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new HobbitonBannersAddon();
			}
		}

		[Constructable]
		public HobbitonBannersAddonDeed()
		{
			Name = "HobbitonBanners";
		}

		public HobbitonBannersAddonDeed( Serial serial ) : base( serial )
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