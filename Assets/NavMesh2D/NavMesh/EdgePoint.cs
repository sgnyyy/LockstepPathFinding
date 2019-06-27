using System.Collections.Generic;
using UnityEngine;

namespace NoLockstep.AI.Navmesh2D {
	public class EdgePoint {
		/**
		 * Triangle which must be crossed to reach the next path point.
		 */
		public Triangle toNode;

		/**
		 * Triangle which was crossed to reach this point.
		 */
		public Triangle fromNode;

		/**
		 * Path edges connected to this point. Can be used for spline generation at some
		 * point perhaps...
		 */
		public List<TriangleEdge> connectingEdges = new List<TriangleEdge>();

		/**
		 * The point where the path crosses an edge.
		 */
		public Vector3 point;

		public EdgePoint(Vector3 point, Triangle toNode){
			this.point = point;
			this.toNode = toNode;
		}
	}
}