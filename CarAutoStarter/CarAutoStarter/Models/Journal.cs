using System;
using System.Collections.Generic;
using System.Text;

namespace CarAutoStarter.Models
{
    public class Journal
    {

        public List<JournalEntry> entireJournal = new List<JournalEntry>();

        public void AddEntry(JournalEntry newEntry)
        {
            entireJournal.Add(newEntry);
        }

    }
}
