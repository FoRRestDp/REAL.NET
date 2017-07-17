﻿namespace REAL.NET.Models.FakeRepo
{
    using Repo;
    using System.Collections.Generic;
    class Model
    {
        private List<NodeInfo> nodeCollection;
        private List<EdgeInfo> edgeCollection;
        public string Name { get => "FakeModel"; }
        /* No need in deep copy. Replace later.*/
        public IEnumerable<NodeInfo> NodeCollection
        {
            /* Deep cloning using lambda expressions*/
            get => nodeCollection.ConvertAll<NodeInfo>(nodeinfo => new NodeInfo(nodeinfo.id, nodeinfo.name, nodeinfo.nodeType, nodeinfo.attributes.ConvertAll<AttributeInfo>(attribute => new AttributeInfo(attribute.name, attribute.attributeType, attribute.value))));
        }
        public IEnumerable<EdgeInfo> EdgeCollection
        {
            /* Deep cloning using lambda expressions*/
            get => edgeCollection.ConvertAll<EdgeInfo>(edgeinfo => new EdgeInfo(edgeinfo.id, edgeinfo.source, edgeinfo.target,edgeinfo.edgeType));
        }

        public Model()
        {
            //TODO Change source-target arguments
            edgeCollection = new List<EdgeInfo>()
            {
                new EdgeInfo("1", "1", "2", Repo.EdgeType.Association),
                new EdgeInfo("2", "5", "3", Repo.EdgeType.Attribute),
                new EdgeInfo("3", "2", "3", Repo.EdgeType.Generalization),
                new EdgeInfo("4", "2", "3", Repo.EdgeType.Type),
                new EdgeInfo("5", "2", "3", Repo.EdgeType.Value),
                new EdgeInfo("6", "2", "3", Repo.EdgeType.Association),
                new EdgeInfo("7", "2", "3", Repo.EdgeType.Attribute),
                new EdgeInfo("8", "2", "3", Repo.EdgeType.Generalization),
                new EdgeInfo("9", "2", "3", Repo.EdgeType.Type),
                new EdgeInfo("10", "2", "3", Repo.EdgeType.Value),
            };
            List<AttributeInfo> node1AttributeCollection = new List<AttributeInfo>()
            {
                new AttributeInfo("Attribute name 1", "Attribute type 1", "Value 1"),
                new AttributeInfo("Attribute name 2", "Attribute type 2", "Value 2"),
                new AttributeInfo("Attribute name 3", "Attribute type 3", "Value 3"),
                new AttributeInfo("Attribute name 4", "Attribute type 4", "Value 4"),
            };
            List<AttributeInfo> node2AttributeCollection = new List<AttributeInfo>()
            {
                new AttributeInfo("Attribute name 6", "Attribute type 6", "Value 6"),
                new AttributeInfo("Attribute name 7", "Attribute type 7", "Value 7"),
            };
            List<AttributeInfo> node3AttributeCollection = new List<AttributeInfo>()
            {
                new AttributeInfo("Attribute name 7", "Attribute type 7", "Value 7"),
                new AttributeInfo("Attribute name 8", "Attribute type 8", "Value 8"),
                new AttributeInfo("Attribute name 9", "Attribute type 9", "Value 9"),
            };
            List<AttributeInfo> node4AttributeCollection = new List<AttributeInfo>()
            {
                new AttributeInfo("Attribute name 10", "Attribute type 10", "Value 10"),
                new AttributeInfo("Attribute name 11", "Attribute type 11", "Value 11"),
                new AttributeInfo("Attribute name 12", "Attribute type 12", "Value 12"),
                new AttributeInfo("Attribute name 13", "Attribute type 13", "Value 13"),
                new AttributeInfo("Attribute name 14", "Attribute type 14", "Value 14"),
            };
            nodeCollection = new List<NodeInfo>()
            {
                new NodeInfo("11","Node_1", NodeType.Attribute,node1AttributeCollection),
                new NodeInfo("12","Node_2", NodeType.Attribute,node2AttributeCollection),
                new NodeInfo("13","Node_3", NodeType.Attribute,node3AttributeCollection),
                new NodeInfo("14","Node_4", NodeType.Attribute,node4AttributeCollection),

            };
        }


    }
}