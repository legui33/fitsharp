﻿// Copyright © 2009 Syterra Software Inc.
// This program is free software; you can redistribute it and/or modify it under the terms of the GNU General Public License version 2.
// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.

using fitSharp.Fit.Model;
using fitSharp.Machine.Engine;
using fitSharp.Machine.Model;

namespace fit.Operators {
    public class ComposeHtml: ComposeOperator<Cell> {
        public bool TryCompose(Processor<Cell> processor, TypedValue instance, ref Tree<Cell> result) {
            if (instance.Type != typeof(StoryTestString)) return false;
            result = HtmlParser.Instance.Parse(instance.ValueString);
            return true;
        }
    }
}
