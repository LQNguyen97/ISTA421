﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class TreeEnumerator<TItem> : IEnumerator<TItem> where TItem : IComparable<TItem>
    {
        private Tree<TItem> currentData = null;
        private TItem currentItem = default(TItem);
        private Queue<TItem> enumData = null;
        public TreeEnumerator(Tree<TItem> data)
        {
            currentData = data;
        }

        public TItem Current
        {
            get
            {
                if (this.enumData == null)
                {
                    throw new InvalidOperationException("Use MoveNext before calling Current");
                }
                return this.currentItem;
            }
        }
        object IEnumerator.Current
        {
            get
            {
                if (this.enumData == null)
                {
                    throw new InvalidOperationException("Use MoveNext before calling Current");
                }
                return this.currentItem;
            }
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            if (enumData == null)
            {
                enumData = new Queue<TItem>();
                populate(enumData, currentData);
            }
            if (enumData.Count > 0)
            {
                currentItem = enumData.Dequeue();
                return true;
            }
            return false;
        }

        public void Reset()
        {
            //throw new NotImplementedException();
        }

        private void populate(Queue<TItem> enumQueue, Tree<TItem> tree)
        {
            if (tree.LeftTree != null)
            {
                populate(enumQueue, tree.LeftTree);
            }

            enumQueue.Enqueue(tree.NodeData);
            if (tree.RightTree != null)
            {
                populate(enumQueue, tree.RightTree);
            }
        }
    }
}
