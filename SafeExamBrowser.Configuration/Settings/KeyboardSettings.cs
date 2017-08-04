﻿/*
 * Copyright (c) 2017 ETH Zürich, Educational Development and Technology (LET)
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using SafeExamBrowser.Contracts.Configuration.Settings;

namespace SafeExamBrowser.Configuration.Settings
{
	public class KeyboardSettings : IKeyboardSettings
	{
		public bool AllowAltTab => false;

		public bool AllowEsc => false;

		public bool AllowF5 => true;
	}
}
