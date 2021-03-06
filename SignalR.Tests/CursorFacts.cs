﻿using Xunit;

namespace SignalR.Tests
{
    public class CursorFacts
    {
        [Fact]
        public void Symmetric()
        {
            var cursor = new Cursor
            {
                Id = 10,
                Key = @"\foo|1,4,\|\\\,"
            };

            var serialized = Cursor.MakeCursor(new[] { cursor });
            var cursors = Cursor.GetCursors(serialized);


            Assert.Equal(cursor.Id, cursors[0].Id);
            Assert.Equal(cursor.Key, cursors[0].Key);
        }
    }
}
