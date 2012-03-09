using System;
using Android.App.Backup;
namespace CodeSnippets
{
	public class BackupSnippet : BackupAgent
	{
		public BackupSnippet()
		{
		}
		
		public void onRestore(BackupDataInput data, int appVersionCode,
		                      ParcelFileDescriptor newState) {
			while (data.ReadNextHeader()) {
				String key = data.getKey();
				int dataSize = data.getDataSize();
				
				if (key.Equals(MY_BACKUP_KEY_ONE)) {
					byte[] buffer = new byte[dataSize];
					data.ReadEntityData(buffer, 0, dataSize);
				}
			}
		}
	}
}

