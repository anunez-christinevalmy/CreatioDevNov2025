namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrYachtServiceSchema

	/// <exclude/>
	public class UsrYachtServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrYachtServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrYachtServiceSchema(UsrYachtServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("630a5105-b45c-47fe-8a17-c0bb49627635");
			Name = "UsrYachtService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e285e19b-8d0d-4117-8634-0451b1bab3ec");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,77,204,204,83,72,206,79,73,85,40,72,44,42,225,229,114,86,6,0,211,19,1,240,18,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("630a5105-b45c-47fe-8a17-c0bb49627635"));
		}

		#endregion

	}

	#endregion

}

