﻿// EvImSync - A tool to sync Evernote notes to IMAP mails and vice versa
// Copyright (C) 2010 - Stefan Kueng

// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.

// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.

// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;

namespace EveImSync
{
    [Serializable]
    public class SyncPairSettings
    {
        public SyncPairSettings()
        {
        }

        public string EvernoteNotebook = string.Empty;

        public string IMAPUsername = string.Empty;

        public string IMAPPassword = string.Empty;
        
        public string IMAPServer = string.Empty;
        
        public string IMAPNotesFolder = string.Empty;

        public DateTime LastSyncTime = new DateTime(0);
    }
}
