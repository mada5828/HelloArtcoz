//----------------------------------------------
//    Google2u: Google Doc Unity integration
//         Copyright © 2015 Litteratus
//
//        This file has been auto-generated
//              Do not manually edit
//----------------------------------------------

using UnityEngine;
using System.Globalization;

namespace Google2u
{
	[System.Serializable]
	public class SampleCursorRow : IGoogle2uRow
	{
		public string _ReticleName;
		public int _ReticleDamage;
		public string _ReticleTextureName;
		public SampleCursorRow(string __G2U_ID, string __ReticleName, string __ReticleDamage, string __ReticleTextureName) 
		{
			_ReticleName = __ReticleName.Trim();
			{
			int res;
				if(int.TryParse(__ReticleDamage, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_ReticleDamage = res;
				else
					Debug.LogError("Failed To Convert _ReticleDamage string: "+ __ReticleDamage +" to int");
			}
			_ReticleTextureName = __ReticleTextureName.Trim();
		}

		public int Length { get { return 3; } }

		public string this[int i]
		{
		    get
		    {
		        return GetStringDataByIndex(i);
		    }
		}

		public string GetStringDataByIndex( int index )
		{
			string ret = System.String.Empty;
			switch( index )
			{
				case 0:
					ret = _ReticleName.ToString();
					break;
				case 1:
					ret = _ReticleDamage.ToString();
					break;
				case 2:
					ret = _ReticleTextureName.ToString();
					break;
			}

			return ret;
		}

		public string GetStringData( string colID )
		{
			var ret = System.String.Empty;
			switch( colID )
			{
				case "_ReticleName":
					ret = _ReticleName.ToString();
					break;
				case "_ReticleDamage":
					ret = _ReticleDamage.ToString();
					break;
				case "_ReticleTextureName":
					ret = _ReticleTextureName.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "_ReticleName" + " : " + _ReticleName.ToString() + "} ";
			ret += "{" + "_ReticleDamage" + " : " + _ReticleDamage.ToString() + "} ";
			ret += "{" + "_ReticleTextureName" + " : " + _ReticleTextureName.ToString() + "} ";
			return ret;
		}
	}
	public class SampleCursor :  Google2uComponentBase, IGoogle2uDB
	{
		public enum rowIds {
			RETICLE_001, RETICLE_002, RETICLE_003
		};
		public string [] rowNames = {
			"RETICLE_001", "RETICLE_002", "RETICLE_003"
		};
		public System.Collections.Generic.List<SampleCursorRow> Rows = new System.Collections.Generic.List<SampleCursorRow>();
		public override void AddRowGeneric (System.Collections.Generic.List<string> input)
		{
			Rows.Add(new SampleCursorRow(input[0],input[1],input[2],input[3]));
		}
		public override void Clear ()
		{
			Rows.Clear();
		}
		public IGoogle2uRow GetGenRow(string in_RowString)
		{
			IGoogle2uRow ret = null;
			try
			{
				ret = Rows[(int)System.Enum.Parse(typeof(rowIds), in_RowString)];
			}
			catch(System.ArgumentException) {
				Debug.LogError( in_RowString + " is not a member of the rowIds enumeration.");
			}
			return ret;
		}
		public IGoogle2uRow GetGenRow(rowIds in_RowID)
		{
			IGoogle2uRow ret = null;
			try
			{
				ret = Rows[(int)in_RowID];
			}
			catch( System.Collections.Generic.KeyNotFoundException ex )
			{
				Debug.LogError( in_RowID + " not found: " + ex.Message );
			}
			return ret;
		}
		public SampleCursorRow GetRow(rowIds in_RowID)
		{
			SampleCursorRow ret = null;
			try
			{
				ret = Rows[(int)in_RowID];
			}
			catch( System.Collections.Generic.KeyNotFoundException ex )
			{
				Debug.LogError( in_RowID + " not found: " + ex.Message );
			}
			return ret;
		}
		public SampleCursorRow GetRow(string in_RowString)
		{
			SampleCursorRow ret = null;
			try
			{
				ret = Rows[(int)System.Enum.Parse(typeof(rowIds), in_RowString)];
			}
			catch(System.ArgumentException) {
				Debug.LogError( in_RowString + " is not a member of the rowIds enumeration.");
			}
			return ret;
		}

	}

}
