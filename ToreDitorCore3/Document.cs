﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.Text.RegularExpressions;

namespace ToreDitorCore
{
    public class Document
    {
        public Document()
        {
            this.Text.Add(new StringBuilder(""));
        }

        public List<StringBuilder> Text { get; } = new List<StringBuilder>();

        public String FlatText
        {
            get {
                String text = "";
                foreach ( StringBuilder line in this.Text ) {
                    text += line.ToString() + "\n";
                }

                return text;
            }
        }
    
        public void ReDo() { ReDo(true); }
        public void ReDo(bool ifRegist)
        {
            if (ifRegist) {

            }
            throw new System.NotImplementedException();
        }

        public void UnDo() { UnDo(true); }
        public void UnDo(bool ifRegist)
        {
            if (ifRegist) {

            }
            throw new System.NotImplementedException();
        }

        public void Append(StringBuilder data) { Append(true, data); }
        public void Append(bool ifRegist, StringBuilder data)
        {
            if (ifRegist) {

            }
            this.Text.Add(data);
        }

        public void Input(char data, int rowNum, int posNum) { Input(true, data, rowNum, posNum); }
        public void Input(bool ifRegist, char data, int posNum, int rowNum)
        {
            if (ifRegist) {

            }
            this.Text[rowNum].Insert(posNum, data);
        }

        public void Insert(int index, StringBuilder data) { Insert(true, index, data); }
        public void Insert(bool ifRegist, int index, StringBuilder data)
        {
            if (ifRegist) {

            }
            this.Text.Insert(index, data);
        }

        public void Clear() { Clear(true); }
        public void Clear(bool ifRegist)
        {
            if (ifRegist) {

            }
            throw new System.NotImplementedException();
        }

        public void Select() { Select(true); }
        public void Select(bool ifRegist)
        {
            if (ifRegist) {

            }
            throw new System.NotImplementedException();
        }

        public void Copy() { Copy(true); }
        public void Copy(bool ifRegist)
        {
            if (ifRegist) {

            }
            throw new System.NotImplementedException();
        }

        public void Paste() { Paste(true); }
        public void Paste(bool ifRegist)
        {
            if (ifRegist) {

            }
            throw new System.NotImplementedException();
        }

        public void Delete(int sPosNum, int sRowNum, int ePosNum, int eRowNum) { Delete(true, sPosNum, sRowNum, ePosNum, eRowNum); }
        public void Delete(bool ifRegist, int sPosNum, int sRowNum, int ePosNum, int eRowNum)
        {
            if (ifRegist) {

            }
            if (sRowNum == eRowNum)
            {

                if (sPosNum < 0)
                { //改行の削除
                    this.Text[sRowNum - 1].Append(this.Text[sRowNum].ToString().Substring(ePosNum));
                    this.Text.RemoveAt(sRowNum);

                } else {
                    this.Text[sRowNum].Remove(sPosNum, ePosNum - sPosNum);
                }
            } else {
                this.Text[sRowNum -1].Remove(sPosNum, this.Text[sRowNum -1].Length - sPosNum);
                this.Text[sRowNum -1].Append(this.Text[eRowNum].ToString().Substring(ePosNum));
                this.Text.RemoveRange(sRowNum, eRowNum - sRowNum);
            }
        }

        public void Replace() { Replace(true); }
        public void Replace(bool ifRegist)
        {
            if (ifRegist) {

            }
            throw new System.NotImplementedException();
        }
      
        public void Flash()
        {
            throw new System.NotImplementedException();
        }
        
        public void Search()
        {
            throw new System.NotImplementedException();
        }

        public void Set(String source) {
            StringReader sr = new StringReader(source);

            this.Text.Clear();
            while (sr.Peek() > -1) {
                this.Append(new StringBuilder(sr.ReadLine()));
            }

            sr.Close();
        }
    }
}
