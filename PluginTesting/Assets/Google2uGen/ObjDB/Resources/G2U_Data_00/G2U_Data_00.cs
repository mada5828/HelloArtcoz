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
	public class G2U_Data_00Row : IGoogle2uRow
	{
		public string _name;
		public int _health;
		public float _lifeSpan;
		public float _moveSpeed;
		public float _infectionChance;
		public int _attackDamage;
		public float _attackCooldown;
		public float _attackRange;
		public float _viewDistance;
		public G2U_Data_00Row(string __ID, string __name, string __health, string __lifeSpan, string __moveSpeed, string __infectionChance, string __attackDamage, string __attackCooldown, string __attackRange, string __viewDistance) 
		{
			_name = __name.Trim();
			{
			int res;
				if(int.TryParse(__health, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_health = res;
				else
					Debug.LogError("Failed To Convert _health string: "+ __health +" to int");
			}
			{
			float res;
				if(float.TryParse(__lifeSpan, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_lifeSpan = res;
				else
					Debug.LogError("Failed To Convert _lifeSpan string: "+ __lifeSpan +" to float");
			}
			{
			float res;
				if(float.TryParse(__moveSpeed, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_moveSpeed = res;
				else
					Debug.LogError("Failed To Convert _moveSpeed string: "+ __moveSpeed +" to float");
			}
			{
			float res;
				if(float.TryParse(__infectionChance, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_infectionChance = res;
				else
					Debug.LogError("Failed To Convert _infectionChance string: "+ __infectionChance +" to float");
			}
			{
			int res;
				if(int.TryParse(__attackDamage, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_attackDamage = res;
				else
					Debug.LogError("Failed To Convert _attackDamage string: "+ __attackDamage +" to int");
			}
			{
			float res;
				if(float.TryParse(__attackCooldown, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_attackCooldown = res;
				else
					Debug.LogError("Failed To Convert _attackCooldown string: "+ __attackCooldown +" to float");
			}
			{
			float res;
				if(float.TryParse(__attackRange, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_attackRange = res;
				else
					Debug.LogError("Failed To Convert _attackRange string: "+ __attackRange +" to float");
			}
			{
			float res;
				if(float.TryParse(__viewDistance, NumberStyles.Any, CultureInfo.InvariantCulture, out res))
					_viewDistance = res;
				else
					Debug.LogError("Failed To Convert _viewDistance string: "+ __viewDistance +" to float");
			}
		}

		public int Length { get { return 9; } }

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
					ret = _name.ToString();
					break;
				case 1:
					ret = _health.ToString();
					break;
				case 2:
					ret = _lifeSpan.ToString();
					break;
				case 3:
					ret = _moveSpeed.ToString();
					break;
				case 4:
					ret = _infectionChance.ToString();
					break;
				case 5:
					ret = _attackDamage.ToString();
					break;
				case 6:
					ret = _attackCooldown.ToString();
					break;
				case 7:
					ret = _attackRange.ToString();
					break;
				case 8:
					ret = _viewDistance.ToString();
					break;
			}

			return ret;
		}

		public string GetStringData( string colID )
		{
			var ret = System.String.Empty;
			switch( colID )
			{
				case "_name":
					ret = _name.ToString();
					break;
				case "_health":
					ret = _health.ToString();
					break;
				case "_lifeSpan":
					ret = _lifeSpan.ToString();
					break;
				case "_moveSpeed":
					ret = _moveSpeed.ToString();
					break;
				case "_infectionChance":
					ret = _infectionChance.ToString();
					break;
				case "_attackDamage":
					ret = _attackDamage.ToString();
					break;
				case "_attackCooldown":
					ret = _attackCooldown.ToString();
					break;
				case "_attackRange":
					ret = _attackRange.ToString();
					break;
				case "_viewDistance":
					ret = _viewDistance.ToString();
					break;
			}

			return ret;
		}
		public override string ToString()
		{
			string ret = System.String.Empty;
			ret += "{" + "_name" + " : " + _name.ToString() + "} ";
			ret += "{" + "_health" + " : " + _health.ToString() + "} ";
			ret += "{" + "_lifeSpan" + " : " + _lifeSpan.ToString() + "} ";
			ret += "{" + "_moveSpeed" + " : " + _moveSpeed.ToString() + "} ";
			ret += "{" + "_infectionChance" + " : " + _infectionChance.ToString() + "} ";
			ret += "{" + "_attackDamage" + " : " + _attackDamage.ToString() + "} ";
			ret += "{" + "_attackCooldown" + " : " + _attackCooldown.ToString() + "} ";
			ret += "{" + "_attackRange" + " : " + _attackRange.ToString() + "} ";
			ret += "{" + "_viewDistance" + " : " + _viewDistance.ToString() + "} ";
			return ret;
		}
	}
	public class G2U_Data_00 :  Google2uComponentBase, IGoogle2uDB
	{
		public enum rowIds {
			ID_Common, ID_Chubby, ID_Brute, ID_Puker, ID_Jock, ID_Biker, ID_Soldier, ID_Bomber, ID_CoinCollector, ID_Leaper, ID_Grabber, ID_Stalker, ID_Trapper, ID_Chef, ID_Vampire, ID_Creeper, ID_Berseker, ID_Shaker
			, ID_Viper, ID_MikeJack
		};
		public string [] rowNames = {
			"ID_Common", "ID_Chubby", "ID_Brute", "ID_Puker", "ID_Jock", "ID_Biker", "ID_Soldier", "ID_Bomber", "ID_CoinCollector", "ID_Leaper", "ID_Grabber", "ID_Stalker", "ID_Trapper", "ID_Chef", "ID_Vampire", "ID_Creeper", "ID_Berseker", "ID_Shaker"
			, "ID_Viper", "ID_MikeJack"
		};
		public System.Collections.Generic.List<G2U_Data_00Row> Rows = new System.Collections.Generic.List<G2U_Data_00Row>();
		public override void AddRowGeneric (System.Collections.Generic.List<string> input)
		{
			Rows.Add(new G2U_Data_00Row(input[0],input[1],input[2],input[3],input[4],input[5],input[6],input[7],input[8],input[9]));
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
		public G2U_Data_00Row GetRow(rowIds in_RowID)
		{
			G2U_Data_00Row ret = null;
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
		public G2U_Data_00Row GetRow(string in_RowString)
		{
			G2U_Data_00Row ret = null;
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
