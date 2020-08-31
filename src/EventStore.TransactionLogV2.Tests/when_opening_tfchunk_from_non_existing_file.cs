using EventStore.Core.TransactionLogV2.Chunks.TFChunk;
using EventStore.Core.TransactionLogV2.Exceptions;
using EventStore.Core.TransactionLogV2.Tests.Helpers;
using NUnit.Framework;

namespace EventStore.Core.TransactionLogV2.Tests {
	[TestFixture]
	public class when_opening_tfchunk_from_non_existing_file : SpecificationWithFile {
		[Test]
		public void it_should_throw_a_file_not_found_exception() {
			Assert.Throws<CorruptDatabaseException>(() => TFChunk.FromCompletedFile(Filename, verifyHash: true,
				5, //Constants.TFChunkInitialReaderCountDefault,
				21));//Constants.TFChunkMaxReaderCountDefault);
		}
	}
}