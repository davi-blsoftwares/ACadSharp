﻿using ACadSharp.Geometry;
using ACadSharp.IO.Templates;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACadSharp.Tables
{
	public class UCS : TableEntry
	{
		public override ObjectType ObjectType => ObjectType.UCS;

		public XYZ PaperSpaceInsertionBase { get; set; }
		public XYZ PaperSpaceExtMin { get; set; }
		public XYZ PaperSpaceExtMax { get; set; }
		public XY PaperSpaceLimitsMin { get; set; }
		public XY PaperSpaceLimitsMax { get; set; }
		public double Elevation { get; set; }
		public XYZ Origin { get; set; }
		public XYZ XAxis { get; set; }
		public XYZ YAxis { get; set; }
		public XYZ OrthographicTopDOrigin { get; set; }
		public XYZ OrthographicBottomDOrigin { get; set; }
		public XYZ OrthographicLeftDOrigin { get; set; }
		public XYZ OrthographicRightDOrigin { get; set; }
		public XYZ OrthographicFrontDOrigin { get; set; }
		public XYZ OrthographicBackDOrigin { get; set; }
		public OrthographicType OrthographicViewType { get; internal set; }
		public OrthographicType OrthographicType { get; internal set; }

		public UCS() : base() { }

		internal UCS(DxfEntryTemplate template) : base(template) { }
	}
}
