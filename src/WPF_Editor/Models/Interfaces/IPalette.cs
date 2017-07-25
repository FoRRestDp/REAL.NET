﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repo;
using WPF_Editor.ViewModels;
namespace WPF_Editor.Models.Interfaces
{
    public interface IPalette
    {
	    /* Gets selected item from palette. If there's no such item it will return null.*/
        IElement SelectedElement { get; set; }
        IEnumerable<INode> Nodes { get;}
        IEnumerable<IEdge> Edges { get;}
        IEnumerable<IElement> Elements { get;}
    }
}
