
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
	public class TwoStoryGrandfatherClockEastAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {11631, 1, -2, 5}, {11631, 1, 0, 5}, {19551, 0, 0, 56}// 1	2	3	
			, {19549, 2, -4, 19}, {19549, 2, 3, 19}// 14	15	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new TwoStoryGrandfatherClockEastAddonDeed();
			}
		}

		[ Constructable ]
		public TwoStoryGrandfatherClockEastAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 1201, 0, 4, 61, 2418, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 1202, -1, 4, 61, 2418, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 1204, -1, 3, 61, 2418, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 1203, 0, 3, 61, 2418, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 1204, -1, -4, 61, 2418, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 1202, -1, -3, 61, 2418, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 1201, 0, -3, 61, 2418, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 1203, 0, -4, 61, 2418, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 2171, -1, -2, 55, 2418, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 2173, -1, -1, 55, 2418, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 18175, 2, 1, 41, 1177, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 41198, -1, 0, 29, 2418, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 18175, 1, -1, 35, 1177, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 19515, 1, 1, 22, 2418, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 19515, 1, 0, 22, 2418, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 19515, 1, -1, 22, 2418, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 19515, 1, -2, 22, 2418, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 35727, -1, 3, 23, 2418, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 42332, -1, 3, 6, 2418, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 13854, -1, 0, 61, 2418, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 1848, -1, 0, 56, 2418, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 2173, 0, 2, 55, 2418, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 2173, -1, 2, 55, 2418, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 2173, 0, -1, 55, 2418, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 2171, -1, 1, 55, 2418, -1, "", 1);// 30
			AddComplexComponent( (BaseAddon) this, 2171, 0, 1, 55, 2418, -1, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 2171, 0, -2, 55, 2418, -1, "", 1);// 32
			AddComplexComponent( (BaseAddon) this, 1848, 0, 3, 56, 2418, -1, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 1848, -1, 3, 56, 2418, -1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 1848, 0, -3, 56, 2418, -1, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 1848, -1, -3, 56, 2418, -1, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 1971, 0, 4, 56, 2418, -1, "", 1);// 37
			AddComplexComponent( (BaseAddon) this, 1971, -1, 4, 56, 2418, -1, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 1974, 0, -4, 56, 2418, -1, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 1974, -1, -4, 55, 2418, -1, "", 1);// 40
			AddComplexComponent( (BaseAddon) this, 1974, 0, -3, 51, 2418, -1, "", 1);// 41
			AddComplexComponent( (BaseAddon) this, 1974, -1, -3, 51, 2418, -1, "", 1);// 42
			AddComplexComponent( (BaseAddon) this, 1971, 0, 3, 51, 2418, -1, "", 1);// 43
			AddComplexComponent( (BaseAddon) this, 1971, -1, 3, 51, 2418, -1, "", 1);// 44
			AddComplexComponent( (BaseAddon) this, 1848, 0, 2, 51, 2418, -1, "", 1);// 45
			AddComplexComponent( (BaseAddon) this, 1848, 0, 1, 51, 2418, -1, "", 1);// 46
			AddComplexComponent( (BaseAddon) this, 1848, 0, 0, 51, 2418, -1, "", 1);// 47
			AddComplexComponent( (BaseAddon) this, 1848, 0, -1, 51, 2418, -1, "", 1);// 48
			AddComplexComponent( (BaseAddon) this, 1848, 0, -2, 51, 2418, -1, "", 1);// 49
			AddComplexComponent( (BaseAddon) this, 1848, -1, 2, 51, 2418, -1, "", 1);// 50
			AddComplexComponent( (BaseAddon) this, 1848, -1, 1, 51, 2418, -1, "", 1);// 51
			AddComplexComponent( (BaseAddon) this, 1848, -1, 0, 51, 2418, -1, "", 1);// 52
			AddComplexComponent( (BaseAddon) this, 1848, -1, -1, 51, 2418, -1, "", 1);// 53
			AddComplexComponent( (BaseAddon) this, 1848, -1, -2, 51, 2418, -1, "", 1);// 54
			AddComplexComponent( (BaseAddon) this, 42369, 1, -4, 32, 2418, -1, "", 1);// 55
			AddComplexComponent( (BaseAddon) this, 42369, 1, 3, 32, 2418, -1, "", 1);// 56
			AddComplexComponent( (BaseAddon) this, 25493, 3, 2, 54, 1923, -1, "Clock Face", 1);// 57
			AddComplexComponent( (BaseAddon) this, 480, 1, -3, 45, 2418, -1, "", 1);// 58
			AddComplexComponent( (BaseAddon) this, 480, 1, 2, 45, 2418, -1, "", 1);// 59
			AddComplexComponent( (BaseAddon) this, 477, 1, 2, 25, 2418, -1, "", 1);// 60
			AddComplexComponent( (BaseAddon) this, 477, 1, -3, 25, 2418, -1, "", 1);// 61
			AddComplexComponent( (BaseAddon) this, 466, 1, 2, 5, 2418, -1, "", 1);// 62
			AddComplexComponent( (BaseAddon) this, 466, 1, -3, 5, 2418, -1, "", 1);// 63
			AddComplexComponent( (BaseAddon) this, 16667, 1, 3, 12, 2418, -1, "", 1);// 64
			AddComplexComponent( (BaseAddon) this, 16667, 1, -4, 12, 2418, -1, "", 1);// 65
			AddComplexComponent( (BaseAddon) this, 16678, 1, 3, 5, 2418, -1, "", 1);// 66
			AddComplexComponent( (BaseAddon) this, 16678, 1, -4, 5, 2418, -1, "", 1);// 67
			AddComplexComponent( (BaseAddon) this, 16664, 0, 0, 30, 2418, -1, "", 1);// 68
			AddComplexComponent( (BaseAddon) this, 16664, 0, 1, 29, 2418, -1, "", 1);// 69
			AddComplexComponent( (BaseAddon) this, 16664, 0, -1, 29, 2418, -1, "", 1);// 70
			AddComplexComponent( (BaseAddon) this, 16664, 0, -2, 29, 2418, -1, "", 1);// 71
			AddComplexComponent( (BaseAddon) this, 16675, 0, 2, 29, 2418, -1, "", 1);// 72
			AddComplexComponent( (BaseAddon) this, 16662, -1, 2, 29, 2418, -1, "", 1);// 73
			AddComplexComponent( (BaseAddon) this, 16677, 0, -3, 29, 2418, -1, "", 1);// 74
			AddComplexComponent( (BaseAddon) this, 16662, -1, -3, 29, 2418, -1, "", 1);// 75
			AddComplexComponent( (BaseAddon) this, 16676, -2, 2, 29, 2418, -1, "", 1);// 76
			AddComplexComponent( (BaseAddon) this, 16664, -2, 1, 29, 2418, -1, "", 1);// 77
			AddComplexComponent( (BaseAddon) this, 16664, -2, 0, 29, 2418, -1, "", 1);// 78
			AddComplexComponent( (BaseAddon) this, 16664, -2, -1, 29, 2418, -1, "", 1);// 79
			AddComplexComponent( (BaseAddon) this, 16664, -2, -2, 29, 2418, -1, "", 1);// 80
			AddComplexComponent( (BaseAddon) this, 16663, -2, -3, 29, 2418, -1, "", 1);// 81
			AddComplexComponent( (BaseAddon) this, 1855, 2, -4, 0, 2418, -1, "", 1);// 82
			AddComplexComponent( (BaseAddon) this, 1848, 1, -4, 0, 2418, -1, "", 1);// 83
			AddComplexComponent( (BaseAddon) this, 1848, 0, -4, 0, 2418, -1, "", 1);// 84
			AddComplexComponent( (BaseAddon) this, 1848, -1, -4, 0, 2418, -1, "", 1);// 85
			AddComplexComponent( (BaseAddon) this, 465, -2, -2, 7, 2418, -1, "", 1);// 86
			AddComplexComponent( (BaseAddon) this, 465, 0, 0, 7, 2418, -1, "", 1);// 87
			AddComplexComponent( (BaseAddon) this, 465, 0, 1, 7, 2418, -1, "", 1);// 88
			AddComplexComponent( (BaseAddon) this, 465, 0, -2, 7, 2418, -1, "", 1);// 89
			AddComplexComponent( (BaseAddon) this, 466, -2, -3, 7, 2418, -1, "", 1);// 90
			AddComplexComponent( (BaseAddon) this, 465, -2, 2, 7, 2418, -1, "", 1);// 91
			AddComplexComponent( (BaseAddon) this, 465, -2, 1, 7, 2418, -1, "", 1);// 92
			AddComplexComponent( (BaseAddon) this, 465, -2, 0, 7, 2418, -1, "", 1);// 93
			AddComplexComponent( (BaseAddon) this, 465, -2, -1, 7, 2418, -1, "", 1);// 94
			AddComplexComponent( (BaseAddon) this, 463, 0, 2, 7, 2418, -1, "", 1);// 95
			AddComplexComponent( (BaseAddon) this, 464, -1, 2, 7, 2418, -1, "", 1);// 96
			AddComplexComponent( (BaseAddon) this, 464, 0, -3, 7, 2418, -1, "", 1);// 97
			AddComplexComponent( (BaseAddon) this, 464, -1, -3, 7, 2418, -1, "", 1);// 98
			AddComplexComponent( (BaseAddon) this, 1848, 1, 2, 0, 2418, -1, "", 1);// 99
			AddComplexComponent( (BaseAddon) this, 1848, 0, 2, 0, 2418, -1, "", 1);// 100
			AddComplexComponent( (BaseAddon) this, 1848, 1, 1, 0, 2418, -1, "", 1);// 101
			AddComplexComponent( (BaseAddon) this, 1848, 0, 1, 0, 2418, -1, "", 1);// 102
			AddComplexComponent( (BaseAddon) this, 1848, 1, 0, 0, 2418, -1, "", 1);// 103
			AddComplexComponent( (BaseAddon) this, 1848, 0, 0, 0, 2418, -1, "", 1);// 104
			AddComplexComponent( (BaseAddon) this, 1848, 1, -1, 0, 2418, -1, "", 1);// 105
			AddComplexComponent( (BaseAddon) this, 1848, 0, -1, 0, 2418, -1, "", 1);// 106
			AddComplexComponent( (BaseAddon) this, 1848, 1, -2, 0, 2418, -1, "", 1);// 107
			AddComplexComponent( (BaseAddon) this, 1848, 0, -2, 0, 2418, -1, "", 1);// 108
			AddComplexComponent( (BaseAddon) this, 1850, 2, 2, 0, 2418, -1, "", 1);// 109
			AddComplexComponent( (BaseAddon) this, 1850, 2, 1, 0, 2418, -1, "", 1);// 110
			AddComplexComponent( (BaseAddon) this, 1850, 2, 0, 0, 2418, -1, "", 1);// 111
			AddComplexComponent( (BaseAddon) this, 1850, 2, -1, 0, 2418, -1, "", 1);// 112
			AddComplexComponent( (BaseAddon) this, 1850, 2, -2, 0, 2418, -1, "", 1);// 113
			AddComplexComponent( (BaseAddon) this, 1854, 2, 3, 0, 2418, -1, "", 1);// 114
			AddComplexComponent( (BaseAddon) this, 1848, 1, 3, 0, 2418, -1, "", 1);// 115
			AddComplexComponent( (BaseAddon) this, 1848, 0, 3, 0, 2418, -1, "", 1);// 116
			AddComplexComponent( (BaseAddon) this, 1850, 2, -3, 0, 2418, -1, "", 1);// 117
			AddComplexComponent( (BaseAddon) this, 1848, 1, -3, 0, 2418, -1, "", 1);// 118
			AddComplexComponent( (BaseAddon) this, 1848, 0, -3, 0, 2418, -1, "", 1);// 119
			AddComplexComponent( (BaseAddon) this, 1848, -1, -3, 0, 2418, -1, "", 1);// 120
			AddComplexComponent( (BaseAddon) this, 1848, -1, -2, 0, 2418, -1, "", 1);// 121
			AddComplexComponent( (BaseAddon) this, 1848, -1, -1, 0, 2418, -1, "", 1);// 122
			AddComplexComponent( (BaseAddon) this, 1848, -1, 0, 0, 2418, -1, "", 1);// 123
			AddComplexComponent( (BaseAddon) this, 1848, -1, 2, 0, 2418, -1, "", 1);// 124
			AddComplexComponent( (BaseAddon) this, 1848, -1, 1, 0, 2418, -1, "", 1);// 125
			AddComplexComponent( (BaseAddon) this, 1848, -1, 3, 0, 2418, -1, "", 1);// 126

		}

		public TwoStoryGrandfatherClockEastAddon( Serial serial ) : base( serial )
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

	public class TwoStoryGrandfatherClockEastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new TwoStoryGrandfatherClockEastAddon();
			}
		}

		[Constructable]
		public TwoStoryGrandfatherClockEastAddonDeed()
		{
			Name = "TwoStoryGrandfatherClockEast";
		}

		public TwoStoryGrandfatherClockEastAddonDeed( Serial serial ) : base( serial )
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