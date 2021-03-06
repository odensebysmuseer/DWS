﻿using System;

#region license
//	GNU General Public License (GNU GPLv3)
 
//	Copyright © 2016 Odense Bys Museer

//	Author: Andriy Volkov

//	This program is free software: you can redistribute it and/or modify
//	it under the terms of the GNU General Public License as published by
//	the Free Software Foundation, either version 3 of the License, or
//	(at your option) any later version.

//	This program is distributed in the hope that it will be useful,
//	but WITHOUT ANY WARRANTY; without even the implied warranty of
//	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
//	See the GNU General Public License for more details.

//	You should have received a copy of the GNU General Public License
//	along with this program.  If not, see <http://www.gnu.org/licenses/>.
#endregion

namespace OBMWS.security
{
    public class WSAuthEntity : WSStaticEntity
    {
        public string access_token = string.Empty;
        public string token_type = "bearer";
        public long expires_in = 0;
        public DateTime issued = DateTime.MinValue;
        public DateTime expires = DateTime.MaxValue;
        public WSAuthState status = WSConstants.AUTH_STATES.NOT_AUTHORIZED;
        private WSUserToken _User = null;
        public WSUserToken User { get { if (_User == null) { _User = new WSUserToken() { role = WSConstants.DEFAULT_USER_ROLE }; } return _User; } set { _User = value; } }
    }
}
