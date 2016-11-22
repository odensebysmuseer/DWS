﻿using OBMWS.security;

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

namespace OBMWS
{
    public class WSSystemRecord : WSStaticRecord
    {
        public WSSystemRecord(MetaFunctions _CFunc) : base(_CFunc, null, WSAccessMode.READ.ACCESS_LEVEL,null) { }
        public WSSystemRecord(MetaFunctions _CFunc, WSSystemEntity _entity, byte _role) : base(_CFunc, _entity, _role) { }
    }
}

