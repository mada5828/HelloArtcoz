using UnityEngine;
using UnityEditor;

namespace Google2u
{
	[CustomEditor(typeof(SampleCursor))]
	public class SampleCursorEditor : Editor
	{
		public int Index = 0;
		public override void OnInspectorGUI ()
		{
			SampleCursor s = target as SampleCursor;
			SampleCursorRow r = s.Rows[ Index ];

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
			GUILayout.Label( "_ReticleName", GUILayout.Width( 150.0f ) );
			{
				EditorGUILayout.TextField( r._ReticleName );
			}
			EditorGUILayout.EndHorizontal();

			EditorGUILayout.BeginHorizontal();
			GUILayout.Label( "_ReticleDamage", GUILayout.Width( 150.0f ) );
			{
				EditorGUILayout.IntField( r._ReticleDamage );
			}
			EditorGUILayout.EndHorizontal();

			EditorGUILayout.BeginHorizontal();
			GUILayout.Label( "_ReticleTextureName", GUILayout.Width( 150.0f ) );
			{
				EditorGUILayout.TextField( r._ReticleTextureName );
			}
			EditorGUILayout.EndHorizontal();

		}
	}
}
