using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmony;

namespace ReachabilityRangeMod
{
	[HarmonyPatch(typeof(Global),"Awake")]
	internal class ReachabilityRangeMod_OffsetGroups_ctor
	{

		private static void Postfix()
		{
			Debug.Log(" === ReachabilityRangeMod_OffsetGroups_ctor Postfix === ");
			//OffsetGroups.InvertedStandardTable = InvertedStandardTable_Alt;
			OffsetGroups.InvertedStandardTableWithCorners = InvertedStandardTableWithCorners_Alt;
		}
		/*
		public static CellOffset[][] InvertedStandardTable_Alt = OffsetTable.Mirror(new CellOffset[28][]
		{
			new CellOffset[1]
			{
				new CellOffset(0, 0)
			},
			new CellOffset[1]
			{
				new CellOffset(0, 1)
			},
			new CellOffset[2]
			{
				new CellOffset(0, 2),
				new CellOffset(0, 1)
			},
			new CellOffset[3]
			{
				new CellOffset(0, 3),
				new CellOffset(0, 1),
				new CellOffset(0, 2)
			},
			new CellOffset[1]
			{
				new CellOffset(0, -1)
			},
			new CellOffset[1]
			{
				new CellOffset(0, -2)
			},
			new CellOffset[3]
			{
				new CellOffset(0, -3),
				new CellOffset(0, -2),
				new CellOffset(0, -1)
			},
			new CellOffset[1]
			{
				new CellOffset(1, 0)
			},
			new CellOffset[2]
			{
				new CellOffset(1, 1),
				new CellOffset(0, 1)
			},
			new CellOffset[2]
			{
				new CellOffset(1, 1),
				new CellOffset(1, 0)
			},
			new CellOffset[3]
			{
				new CellOffset(1, 2),
				new CellOffset(1, 0),
				new CellOffset(1, 1)
			},
			new CellOffset[3]
			{
				new CellOffset(1, 2),
				new CellOffset(0, 1),
				new CellOffset(0, 2)
			},
			new CellOffset[3]
			{
				new CellOffset(1, 3),
				new CellOffset(1, 2),
				new CellOffset(1, 1)
			},
			new CellOffset[4]
			{
				new CellOffset(1, 3),
				new CellOffset(0, 1),
				new CellOffset(0, 2),
				new CellOffset(0, 3)
			},
			new CellOffset[1]
			{
				new CellOffset(1, -1)
			},
			new CellOffset[3]
			{
				new CellOffset(1, -2),
				new CellOffset(1, 0),
				new CellOffset(1, -1)
			},
			new CellOffset[3]
			{
				new CellOffset(1, -2),
				new CellOffset(1, -1),
				new CellOffset(0, -1)
			},
			new CellOffset[3]
			{
				new CellOffset(1, -3),
				new CellOffset(1, 0),
				new CellOffset(1, -1)
			},
			new CellOffset[3]
			{
				new CellOffset(1, -3),
				new CellOffset(0, -1),
				new CellOffset(0, -2)
			},
			new CellOffset[3]
			{
				new CellOffset(1, -3),
				new CellOffset(0, -1),
				new CellOffset(-1, -1)
			},
			new CellOffset[2]
			{
				new CellOffset(2, 0),
				new CellOffset(1, 0)
			},
			new CellOffset[3]
			{
				new CellOffset(2, 1),
				new CellOffset(1, 1),
				new CellOffset(0, 1)
			},
			new CellOffset[3]
			{
				new CellOffset(2, 1),
				new CellOffset(1, 1),
				new CellOffset(1, 0)
			},
			new CellOffset[3]
			{
				new CellOffset(2, 2),
				new CellOffset(1, 2),
				new CellOffset(1, 1)
			},
			new CellOffset[4]
			{
				new CellOffset(2, 3),
				new CellOffset(1, 1),
				new CellOffset(1, 2),
				new CellOffset(1, 3)
			},
			new CellOffset[3]
			{
				new CellOffset(2, -1),
				new CellOffset(2, 0),
				new CellOffset(1, 0)
			},
			new CellOffset[4]
			{
				new CellOffset(2, -2),
				new CellOffset(1, 0),
				new CellOffset(1, -1),
				new CellOffset(2, -1)
			},
			new CellOffset[4]
			{
				new CellOffset(2, -3),
				new CellOffset(1, 0),
				new CellOffset(1, -1),
				new CellOffset(1, -2)
			}
		});
		*/

		public static CellOffset[][] InvertedStandardTableWithCorners_Alt = OffsetTable.Mirror(new CellOffset[27][]
		{
			new CellOffset[1]
			{
				new CellOffset(0, 0)
			},
			new CellOffset[1]
			{
				new CellOffset(0, 1)
			},
			new CellOffset[2]
			{
				new CellOffset(0, 2),
				new CellOffset(0, 1)
			},
			new CellOffset[3]
			{
				new CellOffset(0, 3),
				new CellOffset(0, 1),
				new CellOffset(0, 2)
			},
			new CellOffset[1]
			{
				new CellOffset(0, -1)
			},
			new CellOffset[1]
			{
				new CellOffset(0, -2)
			},
			new CellOffset[3]
			{
				new CellOffset(0, -3),
				new CellOffset(0, -2),
				new CellOffset(0, -1)
			},
			new CellOffset[1]
			{
				new CellOffset(1, 0)
			},
			new CellOffset[1]
			{
				new CellOffset(1, 1)
			},
			new CellOffset[2]
			{
				new CellOffset(1, 1),
				new CellOffset(1, 0)
			},
			new CellOffset[3]
			{
				new CellOffset(1, 2),
				new CellOffset(1, 0),
				new CellOffset(1, 1)
			},
			new CellOffset[3]
			{
				new CellOffset(1, 2),
				new CellOffset(0, 1),
				new CellOffset(0, 2)
			},
			new CellOffset[3]
			{
				new CellOffset(1, 3),
				new CellOffset(1, 2),
				new CellOffset(1, 1)
			},
			new CellOffset[4]
			{
				new CellOffset(1, 3),
				new CellOffset(0, 1),
				new CellOffset(0, 2),
				new CellOffset(0, 3)
			},
			new CellOffset[1]
			{
				new CellOffset(1, -1)
			},
			new CellOffset[3]
			{
				new CellOffset(1, -2),
				new CellOffset(1, 0),
				new CellOffset(1, -1)
			},
			new CellOffset[2]
			{
				new CellOffset(1, -2),
				new CellOffset(1, -1)
			},
			new CellOffset[4]
			{
				new CellOffset(1, -3),
				new CellOffset(1, 0),
				new CellOffset(1, -1),
				new CellOffset(1, -2)
			},
			new CellOffset[5]		// Nuevo
			{
				new CellOffset(1, -4),
				new CellOffset(1, -3),
				new CellOffset(1, 0),
				new CellOffset(1, -1),
				new CellOffset(1, -2)
			},
			new CellOffset[3]
			{
				new CellOffset(1, -3),
				new CellOffset(1, -2),
				new CellOffset(1, -1)
			},
			new CellOffset[2]
			{
				new CellOffset(2, 0),
				new CellOffset(1, 0)
			},
			new CellOffset[2]
			{
				new CellOffset(2, 1),
				new CellOffset(1, 1)
			},
			new CellOffset[3]
			{
				new CellOffset(2, 2),
				new CellOffset(1, 2),
				new CellOffset(1, 1)
			},
			new CellOffset[4]
			{
				new CellOffset(2, 3),
				new CellOffset(1, 1),
				new CellOffset(1, 2),
				new CellOffset(1, 3)
			},
			new CellOffset[3]
			{
				new CellOffset(2, -1),
				new CellOffset(2, 0),
				new CellOffset(1, 0)
			},
			new CellOffset[4]
			{
				new CellOffset(2, -2),
				new CellOffset(1, 0),
				new CellOffset(1, -1),
				new CellOffset(2, -1)
			},
			new CellOffset[4]
			{
				new CellOffset(2, -3),
				new CellOffset(1, 0),
				new CellOffset(1, -1),
				new CellOffset(1, -2)
			}
		});

	}
}
