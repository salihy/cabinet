﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cabinet.FileSystem {
    public interface IPathMapper {
        string MapPath(string path);
    }
}
