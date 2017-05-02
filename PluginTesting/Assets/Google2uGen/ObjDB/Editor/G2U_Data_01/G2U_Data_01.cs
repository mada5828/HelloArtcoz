using UnityEngine;
using UnityEditor;

namespace Google2u
{
	[CustomEditor(typeof(G2U_Data_01))]
	public class G2U_Data_01Editor : Editor
	{
		public int Index = 0;
		public override void OnInspectorGUI ()
		{
			G2U_Data_01 s = target as G2U_Data_01;
			G2U_Data_01Row r = s.Rows[ Index ];

			EditorGUILayout.BeginHorizontal();
			if ( GUILayout.Button("<<") )
			{
				Index = 0;
			}
			if ( GUILayout.Button("<") )
			{
				Index -= 1;
				if ( Index < 0 )
					Index = s.Rows.Count - 1;
			}
			if ( GUILayout.Button(">") )
			{
				Index += 1;
				if ( Index >= s.Rows.Count )
					Index = 0;
			}
			if ( GUILayout.Button(">>") )
			{
				Index = s.Rows.Count - 1;
			}

			EditorGUILayout.EndHorizontal();

			EditorGUILayout.BeginHorizontal();
			GUILayout.Label( "ID", GUILayout.Width( 150.0f ) );
			{
				EditorGUILayout.LabelField( s.rowNames[ Index ] );
			}
			EditorGUILayout.EndHorizontal();

			EditorGUILayout.BeginHorizontal();
			GUILayout.Label( "_name", GUILayout.Width( 150.0f ) );
			{
				EditorGUILayout.TextField( r._name );
			}
			EditorGUILayout.EndHorizontal();

			EditorGUILayout.BeginHorizontal();
			GUILayout.Label( "_health", GUILayout.Width( 150.0f ) );
			{
				EditorGUILayout.IntField( r._health );
			}
			EditorGUILayout.EndHorizontal();

			EditorGUILayout.BeginHorizontal();
			GUILayout.Label( "_moveSpeed", GUILayout.Width( 150.0f ) );
			{
				EditorGUILayout.FloatField( (float)r._moveSpeed );
			}
			EditorGUILayout.EndHorizontal();

			EditorGUILayout.BeginHorizontal();
			GUILayout.Label( "_attackCooldown", GUILayout.Width( 150.0f ) );
			{
				EditorGUILayout.FloatField( (float)r._attackCooldown );
			}
			EditorGUILayout.EndHorizontal();

			EditorGUILayout.BeginHorizontal();
			GUILayout.Label( "_viewDistance", GUILayout.Width( 150.0f ) );
			{
				EditorGUILayout.FloatField( (float)r._viewDistance );
			}
			EditorGUILayout.EndHorizontal();

			EditorGUILayout.BeginHorizontal();
			GUILayout.Label( "_confuseTime", GUILayout.Width( 150.0f ) );
			{
				EditorGUILayout.FloatField( (float)r._confuseTime );
			}
			EditorGUILayout.EndHorizontal();

		}
	}
}
