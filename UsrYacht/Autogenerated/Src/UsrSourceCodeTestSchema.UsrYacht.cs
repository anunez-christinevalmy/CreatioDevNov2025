namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrSourceCodeTestSchema

	/// <exclude/>
	public class UsrSourceCodeTestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrSourceCodeTestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrSourceCodeTestSchema(UsrSourceCodeTestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f7539900-ffa1-49d9-8d8d-4e92fca43db5");
			Name = "UsrSourceCodeTest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e285e19b-8d0d-4117-8634-0451b1bab3ec");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,83,0,0,69,207,108,233,1,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f7539900-ffa1-49d9-8d8d-4e92fca43db5"));
		}

		#endregion

	}

	#endregion

}

