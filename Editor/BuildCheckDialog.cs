using UnityEditor;

namespace Kogane.Internal
{
	[InitializeOnLoad]
	internal static class BuildCheckDialog
	{
		static BuildCheckDialog()
		{
			BuildPlayerWindow.RegisterBuildPlayerHandler( OnBuild );
		}

		private static void OnBuild( BuildPlayerOptions options )
		{
			var isBuild = EditorUtility.DisplayDialog
			(
				title: "Unity",
				message: "ビルドを開始しますか？",
				ok: "はい",
				cancel: "いいえ"
			);

			if ( !isBuild ) return;

			BuildPipeline.BuildPlayer( options );
		}
	}
}