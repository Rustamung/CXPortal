﻿using System;using System.Collections.Generic;using System.Linq;using System.Text;using L3.Cargo.Common;using System.IO;using System.Xml.Serialization;using System.Windows;using L3.Cargo.Common.Xml.Annotations_1_0;namespace L3.Cargo.Translator{    public class AnnotationsTranslator    {        public static Dictionary<string, List<AnnotationInfo>> TranslateXML (Stream AnnotationsXML)        {            Dictionary<string, List<AnnotationInfo>> ret = new Dictionary<string, List<AnnotationInfo>>();            try            {                XmlSerializer serializer = new XmlSerializer(typeof(Annotations));                Annotations annotations = (Annotations)serializer.Deserialize(AnnotationsXML);                List<AnnotationInfo> annotListView0 = new List<AnnotationInfo>();                List<AnnotationInfo> annotListView1 = new List<AnnotationInfo>();                ret = new Dictionary<String, List<AnnotationInfo>>();                if (annotations.Items != null)                {                    foreach (AnnotationArrayItem annot in annotations.Items)                    {                        Point pt = new Point(annot.TopLeftX, annot.TopLeftY);                        AnnotationInfo annotation = new AnnotationInfo                            (pt, annot.Width, annot.Height, annot.RadiusX, annot.RadiusY, annot.Comment);                        if (annot.View == 0)                        {                            annotListView0.Add(annotation);                        }                        else if (annot.View == 1)                        {                            annotListView1.Add(annotation);                        }                    }                }                ret.Add("View0", annotListView0);                ret.Add("View1", annotListView1);            }            catch (Exception ex)            {                throw;            }            return ret;        }        public static Stream CreateXML (Dictionary<String, List<AnnotationInfo>> annotations)        {            XmlSerializer serializer = new XmlSerializer(typeof(Annotations));            Annotations additionalxcase = new Annotations();            List<AnnotationArrayItem> caseInfoList = new List<AnnotationArrayItem>();            if (annotations.ContainsKey("View0"))            {                foreach (AnnotationInfo annot in annotations["View0"])                {                    AnnotationArrayItem additionalInfo = new AnnotationArrayItem();                    additionalInfo.View = 0;                    additionalInfo.Comment = annot.Comment;                    additionalInfo.Height = annot.Height;                    additionalInfo.Width = annot.Width;                    additionalInfo.TopLeftX = annot.TopLeft.X;                    additionalInfo.TopLeftY = annot.TopLeft.Y;                    additionalInfo.RadiusX = annot.RadiusX;                    additionalInfo.RadiusY = annot.RadiuxY;                    caseInfoList.Add(additionalInfo);                }            }            if (annotations.ContainsKey("View1"))            {                foreach (AnnotationInfo annot in annotations["View1"])                {                    AnnotationArrayItem additionalInfo = new AnnotationArrayItem();                    additionalInfo.View = 1;                    additionalInfo.Comment = annot.Comment;                    additionalInfo.Height = annot.Height;                    additionalInfo.Width = annot.Width;                    additionalInfo.TopLeftX = annot.TopLeft.X;                    additionalInfo.TopLeftY = annot.TopLeft.Y;                    additionalInfo.RadiusX = annot.RadiusX;                    additionalInfo.RadiusY = annot.RadiuxY;                    caseInfoList.Add(additionalInfo);                }            }            MemoryStream stream = new MemoryStream();            additionalxcase.Items = caseInfoList.ToArray();            serializer.Serialize(stream, additionalxcase);            stream.Seek(0, SeekOrigin.Begin);            return stream;        }    }}