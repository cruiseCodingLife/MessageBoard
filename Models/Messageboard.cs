using System;
using System.Collections.Generic;

namespace MessageBoard.Models
{
    public partial class MessageBoard
    {
        public int Id { get; set; }
        public int MessageTime { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string MessageDateTime {
            get
            {
                DateTime st = new DateTime(1970, 1, 1, 0, 0, 0, 0);
                DateTime dt = st.AddSeconds(this.MessageTime);
                return dt.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }
    }
}
