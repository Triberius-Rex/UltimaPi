
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
	public class PaddleBoatNorthAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {42087, 3, 5, 23}, {42087, -3, 5, 23}, {43624, 3, 6, 20}// 1	2	3	
			, {43624, -4, 6, 20}, {1981, 2, 3, 20}, {1981, 1, 3, 20}// 4	7	21	
			, {18174, -2, 2, 20}, {15759, 4, 5, 11}, {41198, 3, 2, 1}// 42	52	139	
			, {41198, -3, 2, 1}, {41669, 2, -5, 18}, {41669, 2, -4, 15}// 140	155	156	
			, {42087, 3, -4, 22}, {42087, -3, -4, 22}, {3710, -1, -4, 19}// 157	158	160	
			, {3646, -1, -5, 21}, {3646, -2, -5, 21}, {3646, -2, -4, 19}// 161	162	163	
			, {3644, -1, -5, 17}, {3644, -2, -5, 17}, {3644, -1, -4, 15}// 164	165	166	
			, {3644, -2, -4, 15}, {1981, 1, 1, 20}, {41773, 4, -4, 8}// 167	172	188	
			, {15759, 4, -5, 9}// 231	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new PaddleBoatNorthAddonDeed();
			}
		}

		[ Constructable ]
		public PaddleBoatNorthAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 2905, -2, 2, 22, 1317, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 1981, 2, 2, 20, 2418, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 1981, 2, 4, 20, 2418, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 1981, 0, 2, 20, 2418, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 1981, 0, 3, 20, 2418, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 1981, 0, 4, 20, 2418, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 1981, -1, 4, 20, 2418, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 1981, -1, 3, 20, 2418, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 1981, -1, 2, 20, 2418, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 2904, 1, 4, 23, 1317, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 2904, 1, 3, 23, 1317, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 2904, 1, 2, 23, 1317, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 2902, -2, 4, 22, 1317, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 2902, -2, 3, 22, 1317, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 1981, 1, 4, 20, 2418, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 1981, 1, 2, 20, 2418, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 1981, -2, 4, 20, 2418, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 1981, -2, 3, 20, 2418, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 1981, -2, 2, 20, 2418, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 323, 2, 5, 40, 2122, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 323, -3, 6, 40, 2122, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 10593, 2, 5, 40, 1317, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 10593, 1, 5, 40, 1317, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 10593, 0, 5, 40, 1317, -1, "", 1);// 30
			AddComplexComponent( (BaseAddon) this, 10593, -1, 5, 40, 1317, -1, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 10593, -2, 5, 40, 1317, -1, "", 1);// 32
			AddComplexComponent( (BaseAddon) this, 1849, 3, 7, 13, 1317, -1, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 1849, -3, 7, 13, 1317, -1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 1849, 2, 5, 15, 1317, -1, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 1849, 1, 5, 15, 1317, -1, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 1849, 0, 5, 15, 1317, -1, "", 1);// 37
			AddComplexComponent( (BaseAddon) this, 1849, -1, 5, 15, 1317, -1, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 1849, -2, 5, 15, 1317, -1, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 15796, 2, 7, 6, 2418, -1, "", 1);// 40
			AddComplexComponent( (BaseAddon) this, 15796, -2, 7, 6, 2418, -1, "", 1);// 41
			AddComplexComponent( (BaseAddon) this, 1981, -2, 6, 13, 1317, -1, "", 1);// 43
			AddComplexComponent( (BaseAddon) this, 1848, 3, 6, 15, 1317, -1, "", 1);// 44
			AddComplexComponent( (BaseAddon) this, 1848, -3, 6, 15, 1317, -1, "", 1);// 45
			AddComplexComponent( (BaseAddon) this, 323, -4, 5, 20, 2122, -1, "", 1);// 46
			AddComplexComponent( (BaseAddon) this, 323, -4, 6, 20, 2122, -1, "", 1);// 47
			AddComplexComponent( (BaseAddon) this, 323, -4, 4, 20, 2122, -1, "", 1);// 48
			AddComplexComponent( (BaseAddon) this, 323, 3, 4, 20, 2122, -1, "", 1);// 49
			AddComplexComponent( (BaseAddon) this, 323, 3, 5, 20, 2122, -1, "", 1);// 50
			AddComplexComponent( (BaseAddon) this, 323, 3, 6, 20, 2122, -1, "", 1);// 51
			AddComplexComponent( (BaseAddon) this, 322, 1, 6, 40, 2122, -1, "", 1);// 53
			AddComplexComponent( (BaseAddon) this, 322, 0, 6, 40, 2122, -1, "", 1);// 54
			AddComplexComponent( (BaseAddon) this, 322, -1, 6, 40, 2122, -1, "", 1);// 55
			AddComplexComponent( (BaseAddon) this, 322, -2, 6, 40, 2122, -1, "", 1);// 56
			AddComplexComponent( (BaseAddon) this, 323, -3, 5, 40, 2122, -1, "", 1);// 57
			AddComplexComponent( (BaseAddon) this, 323, -3, 4, 40, 2122, -1, "", 1);// 58
			AddComplexComponent( (BaseAddon) this, 323, -3, 3, 40, 2122, -1, "", 1);// 59
			AddComplexComponent( (BaseAddon) this, 323, -3, 2, 40, 2122, -1, "", 1);// 60
			AddComplexComponent( (BaseAddon) this, 323, 2, 4, 40, 2122, -1, "", 1);// 61
			AddComplexComponent( (BaseAddon) this, 323, 2, 3, 40, 2122, -1, "", 1);// 62
			AddComplexComponent( (BaseAddon) this, 323, 2, 2, 40, 2122, -1, "", 1);// 63
			AddComplexComponent( (BaseAddon) this, 321, 2, 6, 40, 2122, -1, "", 1);// 64
			AddComplexComponent( (BaseAddon) this, 10593, 1, 6, 40, 1317, -1, "", 1);// 65
			AddComplexComponent( (BaseAddon) this, 10593, 1, 4, 40, 1317, -1, "", 1);// 66
			AddComplexComponent( (BaseAddon) this, 10593, 1, 3, 40, 1317, -1, "", 1);// 67
			AddComplexComponent( (BaseAddon) this, 10593, 1, 2, 40, 1317, -1, "", 1);// 68
			AddComplexComponent( (BaseAddon) this, 1848, 2, 4, 15, 1317, -1, "", 1);// 69
			AddComplexComponent( (BaseAddon) this, 1848, 2, 3, 15, 1317, -1, "", 1);// 70
			AddComplexComponent( (BaseAddon) this, 1848, 2, 2, 15, 1317, -1, "", 1);// 71
			AddComplexComponent( (BaseAddon) this, 1981, 2, 6, 13, 1317, -1, "", 1);// 72
			AddComplexComponent( (BaseAddon) this, 1981, 2, 5, 13, 1317, -1, "", 1);// 73
			AddComplexComponent( (BaseAddon) this, 1981, 2, 4, 13, 1317, -1, "", 1);// 74
			AddComplexComponent( (BaseAddon) this, 1981, 2, 3, 13, 1317, -1, "", 1);// 75
			AddComplexComponent( (BaseAddon) this, 1981, 2, 2, 13, 1317, -1, "", 1);// 76
			AddComplexComponent( (BaseAddon) this, 320, 2, 5, 20, 2122, -1, "", 1);// 77
			AddComplexComponent( (BaseAddon) this, 320, -3, 5, 20, 2122, -1, "", 1);// 78
			AddComplexComponent( (BaseAddon) this, 25, -4, 6, 15, 2418, -1, "", 1);// 79
			AddComplexComponent( (BaseAddon) this, 1848, 1, 4, 15, 1317, -1, "", 1);// 80
			AddComplexComponent( (BaseAddon) this, 1848, 0, 4, 15, 1317, -1, "", 1);// 81
			AddComplexComponent( (BaseAddon) this, 1848, -1, 4, 15, 1317, -1, "", 1);// 82
			AddComplexComponent( (BaseAddon) this, 1848, -2, 4, 15, 1317, -1, "", 1);// 83
			AddComplexComponent( (BaseAddon) this, 10593, 2, 4, 40, 1317, -1, "", 1);// 84
			AddComplexComponent( (BaseAddon) this, 10593, 2, 3, 40, 1317, -1, "", 1);// 85
			AddComplexComponent( (BaseAddon) this, 10593, 0, 4, 40, 1317, -1, "", 1);// 86
			AddComplexComponent( (BaseAddon) this, 10593, 0, 3, 40, 1317, -1, "", 1);// 87
			AddComplexComponent( (BaseAddon) this, 10593, -1, 4, 40, 1317, -1, "", 1);// 88
			AddComplexComponent( (BaseAddon) this, 10593, -1, 3, 40, 1317, -1, "", 1);// 89
			AddComplexComponent( (BaseAddon) this, 10593, -2, 4, 40, 1317, -1, "", 1);// 90
			AddComplexComponent( (BaseAddon) this, 10593, -2, 3, 40, 1317, -1, "", 1);// 91
			AddComplexComponent( (BaseAddon) this, 10593, 2, 6, 40, 1317, -1, "", 1);// 92
			AddComplexComponent( (BaseAddon) this, 10593, 2, 2, 40, 1317, -1, "", 1);// 93
			AddComplexComponent( (BaseAddon) this, 10593, 0, 6, 40, 1317, -1, "", 1);// 94
			AddComplexComponent( (BaseAddon) this, 10593, 0, 2, 40, 1317, -1, "", 1);// 95
			AddComplexComponent( (BaseAddon) this, 10593, -1, 6, 40, 1317, -1, "", 1);// 96
			AddComplexComponent( (BaseAddon) this, 10593, -1, 2, 40, 1317, -1, "", 1);// 97
			AddComplexComponent( (BaseAddon) this, 10593, -2, 6, 40, 1317, -1, "", 1);// 98
			AddComplexComponent( (BaseAddon) this, 10593, -2, 2, 40, 1317, -1, "", 1);// 99
			AddComplexComponent( (BaseAddon) this, 315, 2, 3, 20, 2122, 40, "", 1);// 100
			AddComplexComponent( (BaseAddon) this, 315, -3, 3, 20, 2122, 40, "", 1);// 101
			AddComplexComponent( (BaseAddon) this, 313, 2, 2, 20, 2122, -1, "", 1);// 102
			AddComplexComponent( (BaseAddon) this, 313, -3, 2, 20, 2122, -1, "", 1);// 103
			AddComplexComponent( (BaseAddon) this, 301, 2, 4, 20, 2122, -1, "", 1);// 104
			AddComplexComponent( (BaseAddon) this, 301, -3, 4, 20, 2122, -1, "", 1);// 105
			AddComplexComponent( (BaseAddon) this, 1848, 3, 5, 15, 1317, -1, "", 1);// 106
			AddComplexComponent( (BaseAddon) this, 1848, 3, 4, 15, 1317, -1, "", 1);// 107
			AddComplexComponent( (BaseAddon) this, 1848, -3, 5, 15, 1317, -1, "", 1);// 108
			AddComplexComponent( (BaseAddon) this, 1848, -3, 4, 15, 1317, -1, "", 1);// 109
			AddComplexComponent( (BaseAddon) this, 1848, 1, 3, 15, 1317, -1, "", 1);// 110
			AddComplexComponent( (BaseAddon) this, 1848, 0, 3, 15, 1317, -1, "", 1);// 111
			AddComplexComponent( (BaseAddon) this, 1848, -1, 3, 15, 1317, -1, "", 1);// 112
			AddComplexComponent( (BaseAddon) this, 1848, -2, 3, 15, 1317, -1, "", 1);// 113
			AddComplexComponent( (BaseAddon) this, 1848, 1, 2, 15, 1317, -1, "", 1);// 114
			AddComplexComponent( (BaseAddon) this, 1848, 0, 2, 15, 1317, -1, "", 1);// 115
			AddComplexComponent( (BaseAddon) this, 1848, -1, 2, 15, 1317, -1, "", 1);// 116
			AddComplexComponent( (BaseAddon) this, 1848, -2, 2, 15, 1317, -1, "", 1);// 117
			AddComplexComponent( (BaseAddon) this, 1848, -3, 6, 8, 1154, -1, "", 1);// 118
			AddComplexComponent( (BaseAddon) this, 1848, -3, 5, 8, 2418, -1, "", 1);// 119
			AddComplexComponent( (BaseAddon) this, 1848, 3, 6, 9, 1154, -1, "", 1);// 120
			AddComplexComponent( (BaseAddon) this, 1848, 3, 5, 9, 1154, -1, "", 1);// 121
			AddComplexComponent( (BaseAddon) this, 1981, 3, 6, 13, 1317, -1, "", 1);// 122
			AddComplexComponent( (BaseAddon) this, 1981, 3, 5, 13, 1317, -1, "", 1);// 123
			AddComplexComponent( (BaseAddon) this, 1981, 3, 4, 13, 1317, -1, "", 1);// 124
			AddComplexComponent( (BaseAddon) this, 1981, 1, 6, 13, 1317, -1, "", 1);// 125
			AddComplexComponent( (BaseAddon) this, 1981, 1, 5, 13, 1317, -1, "", 1);// 126
			AddComplexComponent( (BaseAddon) this, 1981, 1, 4, 13, 1317, -1, "", 1);// 127
			AddComplexComponent( (BaseAddon) this, 1981, 0, 6, 13, 1317, -1, "", 1);// 128
			AddComplexComponent( (BaseAddon) this, 1981, 0, 5, 13, 1317, -1, "", 1);// 129
			AddComplexComponent( (BaseAddon) this, 1981, 0, 4, 13, 1317, -1, "", 1);// 130
			AddComplexComponent( (BaseAddon) this, 1981, -1, 6, 13, 1317, -1, "", 1);// 131
			AddComplexComponent( (BaseAddon) this, 1981, -1, 5, 13, 1317, -1, "", 1);// 132
			AddComplexComponent( (BaseAddon) this, 1981, -1, 4, 13, 1317, -1, "", 1);// 133
			AddComplexComponent( (BaseAddon) this, 1981, -2, 5, 13, 1317, -1, "", 1);// 134
			AddComplexComponent( (BaseAddon) this, 1981, -2, 4, 13, 1317, -1, "", 1);// 135
			AddComplexComponent( (BaseAddon) this, 1981, -3, 6, 13, 1317, -1, "", 1);// 136
			AddComplexComponent( (BaseAddon) this, 1981, -3, 5, 13, 1317, -1, "", 1);// 137
			AddComplexComponent( (BaseAddon) this, 1981, -3, 4, 13, 1317, -1, "", 1);// 138
			AddComplexComponent( (BaseAddon) this, 1981, 1, 3, 13, 1317, -1, "", 1);// 141
			AddComplexComponent( (BaseAddon) this, 1981, 1, 2, 13, 1317, -1, "", 1);// 142
			AddComplexComponent( (BaseAddon) this, 1981, 0, 3, 13, 1317, -1, "", 1);// 143
			AddComplexComponent( (BaseAddon) this, 1981, 0, 2, 13, 1317, -1, "", 1);// 144
			AddComplexComponent( (BaseAddon) this, 1981, -1, 3, 13, 1317, -1, "", 1);// 145
			AddComplexComponent( (BaseAddon) this, 1981, -1, 2, 13, 1317, -1, "", 1);// 146
			AddComplexComponent( (BaseAddon) this, 1981, -2, 3, 13, 1317, -1, "", 1);// 147
			AddComplexComponent( (BaseAddon) this, 1981, -2, 2, 13, 1317, -1, "", 1);// 148
			AddComplexComponent( (BaseAddon) this, 1848, -3, 7, 8, 1154, -1, "", 1);// 149
			AddComplexComponent( (BaseAddon) this, 1971, 3, 8, 9, 1154, -1, "", 1);// 150
			AddComplexComponent( (BaseAddon) this, 1971, -3, 8, 8, 1154, -1, "", 1);// 151
			AddComplexComponent( (BaseAddon) this, 1848, -3, 4, 8, 2418, -1, "", 1);// 152
			AddComplexComponent( (BaseAddon) this, 1848, 3, 7, 9, 1154, -1, "", 1);// 153
			AddComplexComponent( (BaseAddon) this, 1848, 3, 4, 9, 1154, -1, "", 1);// 154
			AddComplexComponent( (BaseAddon) this, 2998, 4, 0, 8, 0, -1, "Festival Ferry", 1);// 159
			AddComplexComponent( (BaseAddon) this, 1981, 2, 1, 20, 2418, -1, "", 1);// 168
			AddComplexComponent( (BaseAddon) this, 1981, 0, 1, 20, 2418, -1, "", 1);// 169
			AddComplexComponent( (BaseAddon) this, 1981, -1, 1, 20, 2418, -1, "", 1);// 170
			AddComplexComponent( (BaseAddon) this, 2904, 1, 1, 23, 1317, -1, "", 1);// 171
			AddComplexComponent( (BaseAddon) this, 1848, -3, -4, 15, 1317, -1, "", 1);// 173
			AddComplexComponent( (BaseAddon) this, 1848, -3, -5, 15, 1317, -1, "", 1);// 174
			AddComplexComponent( (BaseAddon) this, 1848, 3, -5, 15, 1317, -1, "", 1);// 175
			AddComplexComponent( (BaseAddon) this, 1848, 3, -4, 15, 1317, -1, "", 1);// 176
			AddComplexComponent( (BaseAddon) this, 1851, 2, 0, 15, 1317, -1, "", 1);// 177
			AddComplexComponent( (BaseAddon) this, 1851, 1, 0, 15, 1317, -1, "", 1);// 178
			AddComplexComponent( (BaseAddon) this, 1851, 0, 0, 15, 1317, -1, "", 1);// 179
			AddComplexComponent( (BaseAddon) this, 1851, -1, 0, 15, 1317, -1, "", 1);// 180
			AddComplexComponent( (BaseAddon) this, 1851, -2, 0, 15, 1317, -1, "", 1);// 181
			AddComplexComponent( (BaseAddon) this, 1848, 3, -1, 15, 1317, -1, "", 1);// 182
			AddComplexComponent( (BaseAddon) this, 1848, -3, -1, 15, 1317, -1, "", 1);// 183
			AddComplexComponent( (BaseAddon) this, 1848, 3, 0, 15, 1317, -1, "", 1);// 184
			AddComplexComponent( (BaseAddon) this, 1848, -3, 0, 15, 1317, -1, "", 1);// 185
			AddComplexComponent( (BaseAddon) this, 1981, -3, 0, 13, 1317, -1, "", 1);// 186
			AddComplexComponent( (BaseAddon) this, 39371, -2, 1, 21, 1317, -1, "", 1);// 187
			AddComplexComponent( (BaseAddon) this, 323, 2, 1, 40, 2122, -1, "", 1);// 189
			AddComplexComponent( (BaseAddon) this, 323, -3, 1, 40, 2122, -1, "", 1);// 190
			AddComplexComponent( (BaseAddon) this, 10593, 2, 1, 40, 1317, -1, "", 1);// 191
			AddComplexComponent( (BaseAddon) this, 10593, 1, 1, 40, 1317, -1, "", 1);// 192
			AddComplexComponent( (BaseAddon) this, 10593, 0, 1, 40, 1317, -1, "", 1);// 193
			AddComplexComponent( (BaseAddon) this, 10593, -1, 1, 40, 1317, -1, "", 1);// 194
			AddComplexComponent( (BaseAddon) this, 10593, -2, 1, 40, 1317, -1, "", 1);// 195
			AddComplexComponent( (BaseAddon) this, 324, 3, -7, 18, 2122, -1, "", 1);// 196
			AddComplexComponent( (BaseAddon) this, 323, 3, -5, 18, 2122, -1, "", 1);// 197
			AddComplexComponent( (BaseAddon) this, 323, -4, -5, 18, 2122, -1, "", 1);// 198
			AddComplexComponent( (BaseAddon) this, 1848, 3, -5, 12, 1317, -1, "", 1);// 199
			AddComplexComponent( (BaseAddon) this, 1981, 3, -6, 17, 1317, -1, "", 1);// 200
			AddComplexComponent( (BaseAddon) this, 1981, 2, -6, 17, 1317, -1, "", 1);// 201
			AddComplexComponent( (BaseAddon) this, 1981, 1, -6, 17, 1317, -1, "", 1);// 202
			AddComplexComponent( (BaseAddon) this, 1981, 0, -6, 17, 1317, -1, "", 1);// 203
			AddComplexComponent( (BaseAddon) this, 1981, -1, -6, 17, 1317, -1, "", 1);// 204
			AddComplexComponent( (BaseAddon) this, 1981, -2, -6, 17, 1317, -1, "", 1);// 205
			AddComplexComponent( (BaseAddon) this, 1981, -3, -6, 17, 1317, -1, "", 1);// 206
			AddComplexComponent( (BaseAddon) this, 1848, 3, -6, 13, 1317, -1, "", 1);// 207
			AddComplexComponent( (BaseAddon) this, 1988, 3, -7, 16, 1317, -1, "", 1);// 208
			AddComplexComponent( (BaseAddon) this, 1981, 2, -7, 17, 1317, -1, "", 1);// 209
			AddComplexComponent( (BaseAddon) this, 1981, 1, -7, 17, 1317, -1, "", 1);// 210
			AddComplexComponent( (BaseAddon) this, 1981, 0, -7, 17, 1317, -1, "", 1);// 211
			AddComplexComponent( (BaseAddon) this, 1981, -1, -7, 17, 1317, -1, "", 1);// 212
			AddComplexComponent( (BaseAddon) this, 1981, -2, -7, 17, 1317, -1, "", 1);// 213
			AddComplexComponent( (BaseAddon) this, 1987, -3, -7, 17, 1317, -1, "", 1);// 214
			AddComplexComponent( (BaseAddon) this, 1981, 2, -5, 15, 1317, -1, "", 1);// 215
			AddComplexComponent( (BaseAddon) this, 1981, 1, -5, 15, 1317, -1, "", 1);// 216
			AddComplexComponent( (BaseAddon) this, 1981, 0, -5, 15, 1317, -1, "", 1);// 217
			AddComplexComponent( (BaseAddon) this, 1981, -1, -5, 15, 1317, -1, "", 1);// 218
			AddComplexComponent( (BaseAddon) this, 1981, -2, -5, 15, 1317, -1, "", 1);// 219
			AddComplexComponent( (BaseAddon) this, 1848, 3, -5, 8, 2418, -1, "", 1);// 220
			AddComplexComponent( (BaseAddon) this, 1848, -3, -5, 8, 1317, -1, "", 1);// 221
			AddComplexComponent( (BaseAddon) this, 324, -4, -7, 18, 2122, -1, "", 1);// 222
			AddComplexComponent( (BaseAddon) this, 323, -4, 0, 18, 2122, -1, "", 1);// 223
			AddComplexComponent( (BaseAddon) this, 323, -4, -1, 18, 2122, -1, "", 1);// 224
			AddComplexComponent( (BaseAddon) this, 323, -4, -4, 18, 2122, -1, "", 1);// 225
			AddComplexComponent( (BaseAddon) this, 323, -4, -6, 18, 2122, -1, "", 1);// 226
			AddComplexComponent( (BaseAddon) this, 323, 3, 0, 18, 2122, -1, "", 1);// 227
			AddComplexComponent( (BaseAddon) this, 323, 3, -1, 18, 2122, -1, "", 1);// 228
			AddComplexComponent( (BaseAddon) this, 323, 3, -4, 18, 2122, -1, "", 1);// 229
			AddComplexComponent( (BaseAddon) this, 323, 3, -6, 18, 2122, -1, "", 1);// 230
			AddComplexComponent( (BaseAddon) this, 324, -3, -1, 40, 2122, -1, "", 1);// 232
			AddComplexComponent( (BaseAddon) this, 322, 2, -1, 40, 2122, -1, "", 1);// 233
			AddComplexComponent( (BaseAddon) this, 322, 1, -1, 40, 2122, -1, "", 1);// 234
			AddComplexComponent( (BaseAddon) this, 322, 0, -1, 40, 2122, -1, "", 1);// 235
			AddComplexComponent( (BaseAddon) this, 322, -1, -1, 40, 2122, -1, "", 1);// 236
			AddComplexComponent( (BaseAddon) this, 322, -2, -1, 40, 2122, -1, "", 1);// 237
			AddComplexComponent( (BaseAddon) this, 323, -3, 0, 40, 2122, -1, "", 1);// 238
			AddComplexComponent( (BaseAddon) this, 323, 2, 0, 40, 2122, -1, "", 1);// 239
			AddComplexComponent( (BaseAddon) this, 10593, 1, 0, 40, 1317, -1, "", 1);// 240
			AddComplexComponent( (BaseAddon) this, 1848, 2, 1, 15, 1317, -1, "", 1);// 241
			AddComplexComponent( (BaseAddon) this, 1981, 2, 1, 13, 1317, -1, "", 1);// 242
			AddComplexComponent( (BaseAddon) this, 1981, 2, 0, 13, 1317, -1, "", 1);// 243
			AddComplexComponent( (BaseAddon) this, 1981, 2, -1, 13, 1317, -1, "", 1);// 244
			AddComplexComponent( (BaseAddon) this, 1981, 2, -2, 13, 1317, -1, "", 1);// 245
			AddComplexComponent( (BaseAddon) this, 1981, 2, -3, 13, 1317, -1, "", 1);// 246
			AddComplexComponent( (BaseAddon) this, 1981, 2, -4, 13, 1317, -1, "", 1);// 247
			AddComplexComponent( (BaseAddon) this, 317, 2, 1, 20, 2122, -1, "", 1);// 248
			AddComplexComponent( (BaseAddon) this, 317, -3, 1, 20, 2122, -1, "", 1);// 249
			AddComplexComponent( (BaseAddon) this, 25, -4, 0, 15, 2418, -1, "", 1);// 250
			AddComplexComponent( (BaseAddon) this, 25, -4, -1, 15, 2418, -1, "", 1);// 251
			AddComplexComponent( (BaseAddon) this, 25, -4, -4, 15, 2418, -1, "", 1);// 252
			AddComplexComponent( (BaseAddon) this, 25, -4, -5, 15, 1317, -1, "", 1);// 253
			AddComplexComponent( (BaseAddon) this, 10593, 2, 0, 40, 1317, -1, "", 1);// 254
			AddComplexComponent( (BaseAddon) this, 10593, 0, 0, 40, 1317, -1, "", 1);// 255
			AddComplexComponent( (BaseAddon) this, 10593, -1, 0, 40, 1317, -1, "", 1);// 256
			AddComplexComponent( (BaseAddon) this, 10593, -2, 0, 40, 1317, -1, "", 1);// 257
			AddComplexComponent( (BaseAddon) this, 1848, 1, 1, 15, 1317, -1, "", 1);// 258
			AddComplexComponent( (BaseAddon) this, 1848, 0, 1, 15, 1317, -1, "", 1);// 259
			AddComplexComponent( (BaseAddon) this, 1848, -1, 1, 15, 1317, -1, "", 1);// 260
			AddComplexComponent( (BaseAddon) this, 1848, -2, 1, 15, 2418, -1, "", 1);// 261
			AddComplexComponent( (BaseAddon) this, 1981, 3, 0, 15, 1317, -1, "", 1);// 262
			AddComplexComponent( (BaseAddon) this, 1981, -4, 0, 15, 2418, -1, "", 1);// 263
			AddComplexComponent( (BaseAddon) this, 1848, 3, 0, 8, 1154, -1, "", 1);// 264
			AddComplexComponent( (BaseAddon) this, 1981, 3, 0, 13, 1317, -1, "", 1);// 265
			AddComplexComponent( (BaseAddon) this, 1825, -3, 0, 8, 2418, -1, "", 1);// 266
			AddComplexComponent( (BaseAddon) this, 1981, -2, 0, 13, 2418, -1, "", 1);// 267
			AddComplexComponent( (BaseAddon) this, 1981, 3, -1, 13, 1317, -1, "", 1);// 268
			AddComplexComponent( (BaseAddon) this, 1981, 3, -2, 13, 1317, -1, "", 1);// 269
			AddComplexComponent( (BaseAddon) this, 1981, 3, -3, 13, 1317, -1, "", 1);// 270
			AddComplexComponent( (BaseAddon) this, 1981, 3, -4, 13, 1317, -1, "", 1);// 271
			AddComplexComponent( (BaseAddon) this, 1981, 1, 1, 13, 1317, -1, "", 1);// 272
			AddComplexComponent( (BaseAddon) this, 1981, 1, 0, 13, 1317, -1, "", 1);// 273
			AddComplexComponent( (BaseAddon) this, 1981, 1, -1, 13, 1317, -1, "", 1);// 274
			AddComplexComponent( (BaseAddon) this, 1981, 1, -2, 13, 1317, -1, "", 1);// 275
			AddComplexComponent( (BaseAddon) this, 1981, 1, -3, 13, 1317, -1, "", 1);// 276
			AddComplexComponent( (BaseAddon) this, 1981, 1, -4, 13, 1317, -1, "", 1);// 277
			AddComplexComponent( (BaseAddon) this, 1981, 0, 1, 13, 1317, -1, "", 1);// 278
			AddComplexComponent( (BaseAddon) this, 1981, 0, 0, 13, 1317, -1, "", 1);// 279
			AddComplexComponent( (BaseAddon) this, 1981, 0, -1, 13, 1317, -1, "", 1);// 280
			AddComplexComponent( (BaseAddon) this, 1981, 0, -2, 13, 1317, -1, "", 1);// 281
			AddComplexComponent( (BaseAddon) this, 1981, 0, -3, 13, 1317, -1, "", 1);// 282
			AddComplexComponent( (BaseAddon) this, 1981, 0, -4, 13, 1317, -1, "", 1);// 283
			AddComplexComponent( (BaseAddon) this, 1981, -1, 1, 13, 1317, -1, "", 1);// 284
			AddComplexComponent( (BaseAddon) this, 1981, -1, 0, 13, 1317, -1, "", 1);// 285
			AddComplexComponent( (BaseAddon) this, 1981, -1, -1, 13, 1317, -1, "", 1);// 286
			AddComplexComponent( (BaseAddon) this, 1981, -1, -2, 13, 1317, -1, "", 1);// 287
			AddComplexComponent( (BaseAddon) this, 1981, -1, -3, 13, 1317, -1, "", 1);// 288
			AddComplexComponent( (BaseAddon) this, 1981, -1, -4, 13, 1317, -1, "", 1);// 289
			AddComplexComponent( (BaseAddon) this, 1981, -2, 1, 13, 1317, -1, "", 1);// 290
			AddComplexComponent( (BaseAddon) this, 1981, -2, 0, 13, 1317, -1, "", 1);// 291
			AddComplexComponent( (BaseAddon) this, 1981, -2, -1, 13, 1317, -1, "", 1);// 292
			AddComplexComponent( (BaseAddon) this, 1981, -2, -2, 13, 1317, -1, "", 1);// 293
			AddComplexComponent( (BaseAddon) this, 1981, -2, -3, 13, 1317, -1, "", 1);// 294
			AddComplexComponent( (BaseAddon) this, 1981, -2, -4, 13, 1317, -1, "", 1);// 295
			AddComplexComponent( (BaseAddon) this, 1981, -3, -1, 13, 1317, -1, "", 1);// 296
			AddComplexComponent( (BaseAddon) this, 1981, -3, -2, 13, 1317, -1, "", 1);// 297
			AddComplexComponent( (BaseAddon) this, 1981, -3, -3, 13, 1317, -1, "", 1);// 298
			AddComplexComponent( (BaseAddon) this, 1981, -3, -4, 13, 1317, -1, "", 1);// 299
			AddComplexComponent( (BaseAddon) this, 1848, 3, -3, 8, 1154, -1, "", 1);// 300
			AddComplexComponent( (BaseAddon) this, 1825, -3, -1, 8, 2418, -1, "", 1);// 301
			AddComplexComponent( (BaseAddon) this, 1825, -3, -2, 8, 2418, -1, "", 1);// 302
			AddComplexComponent( (BaseAddon) this, 1825, -3, -3, 8, 2418, -1, "", 1);// 303
			AddComplexComponent( (BaseAddon) this, 1825, -3, -4, 8, 2418, -1, "", 1);// 304
			AddComplexComponent( (BaseAddon) this, 1848, -3, -6, 8, 1317, -1, "", 1);// 305
			AddComplexComponent( (BaseAddon) this, 1848, 3, -1, 8, 1154, -1, "", 1);// 306
			AddComplexComponent( (BaseAddon) this, 1848, 3, -2, 8, 1154, -1, "", 1);// 307
			AddComplexComponent( (BaseAddon) this, 1848, 3, -4, 8, 1154, -1, "", 1);// 308
			AddComplexComponent( (BaseAddon) this, 1848, 3, -6, 8, 1154, -1, "", 1);// 309
			AddComplexComponent( (BaseAddon) this, 1848, -3, -6, 12, 1317, -1, "", 1);// 310
			AddComplexComponent( (BaseAddon) this, 15941, -4, -8, 0, 1154, -1, "", 1);// 311
			AddComplexComponent( (BaseAddon) this, 15941, 2, -8, 0, 1154, -1, "", 1);// 312

		}

		public PaddleBoatNorthAddon( Serial serial ) : base( serial )
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

	public class PaddleBoatNorthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new PaddleBoatNorthAddon();
			}
		}

		[Constructable]
		public PaddleBoatNorthAddonDeed()
		{
			Name = "PaddleBoatNorth";
		}

		public PaddleBoatNorthAddonDeed( Serial serial ) : base( serial )
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