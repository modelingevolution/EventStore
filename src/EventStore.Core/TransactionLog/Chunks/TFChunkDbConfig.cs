using EventStore.Common.Utils;
using EventStore.Core.TransactionLog.Checkpoint;
using EventStore.Core.TransactionLog.FileNamingStrategy;

namespace EventStore.Core.TransactionLog.Chunks {
	public class TFChunkDbConfig {
		public readonly string Path;
		public readonly int ChunkSize;
		public readonly long MaxChunksCacheSize;
		public readonly ICheckpoint WriterCheckpoint;
		public readonly ICheckpoint ChaserCheckpoint;
		public readonly ICheckpoint EpochCheckpoint;
		public readonly ICheckpoint ProposedEpochCheckpoint;
		public readonly ICheckpoint TruncateCheckpoint;
		public readonly ICheckpoint ReplicationCheckpoint;
		public readonly ICheckpoint IndexCheckpoint;
		public readonly IFileNamingStrategy FileNamingStrategy;
		public readonly bool InMemDb;
		public readonly bool Unbuffered;
		public readonly bool WriteThrough;
		public readonly int InitialReaderCount;
		public readonly int MaxReaderCount;
		public readonly bool OptimizeReadSideCache;
		public readonly bool ReduceFileCachePressure;
		public readonly long MaxTruncation;

		public TFChunkDbConfig(string path,
			IFileNamingStrategy fileNamingStrategy,
			int chunkSize,
			long maxChunksCacheSize,
			ICheckpoint writerCheckpoint,
			ICheckpoint chaserCheckpoint,
			ICheckpoint epochCheckpoint,
			ICheckpoint proposedEpochCheckpoint,
			ICheckpoint truncateCheckpoint,
			ICheckpoint replicationCheckpoint,
			ICheckpoint indexCheckpoint,
			int initialReaderCount,
			int maxReaderCount,
			bool inMemDb = false,
			bool unbuffered = false,
			bool writethrough = false,
			bool optimizeReadSideCache = false,
			bool reduceFileCachePressure = false,
			long maxTruncation = 256 * 1024 * 1024) {
			Ensure.NotNullOrEmpty(path, "path");
			Ensure.NotNull(fileNamingStrategy, "fileNamingStrategy");
			Ensure.Positive(chunkSize, "chunkSize");
			Ensure.Nonnegative(maxChunksCacheSize, "maxChunksCacheSize");
			Ensure.NotNull(writerCheckpoint, "writerCheckpoint");
			Ensure.NotNull(chaserCheckpoint, "chaserCheckpoint");
			Ensure.NotNull(epochCheckpoint, "epochCheckpoint");
			Ensure.NotNull(proposedEpochCheckpoint, "proposedEpochCheckpoint");
			Ensure.NotNull(truncateCheckpoint, "truncateCheckpoint");
			Ensure.NotNull(replicationCheckpoint, "replicationCheckpoint");
			Ensure.NotNull(indexCheckpoint, "indexCheckpoint");
			Ensure.Positive(initialReaderCount, "initialReaderCount");
			Ensure.Positive(maxReaderCount, "maxReaderCount");

			Path = path;
			ChunkSize = chunkSize;
			MaxChunksCacheSize = maxChunksCacheSize;
			WriterCheckpoint = writerCheckpoint;
			ChaserCheckpoint = chaserCheckpoint;
			EpochCheckpoint = epochCheckpoint;
			ProposedEpochCheckpoint = proposedEpochCheckpoint;
			TruncateCheckpoint = truncateCheckpoint;
			ReplicationCheckpoint = replicationCheckpoint;
			IndexCheckpoint = indexCheckpoint;
			FileNamingStrategy = fileNamingStrategy;
			InMemDb = inMemDb;
			Unbuffered = unbuffered;
			WriteThrough = writethrough;
			InitialReaderCount = initialReaderCount;
			MaxReaderCount = maxReaderCount;
			OptimizeReadSideCache = optimizeReadSideCache;
			ReduceFileCachePressure = reduceFileCachePressure;
			MaxTruncation = maxTruncation;
		}
	}
}
