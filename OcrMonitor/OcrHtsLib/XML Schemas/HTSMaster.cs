﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3603
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

//
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
//
namespace L3.Cargo.OCR.Messages.ocr_master {
    using System.Xml.Serialization;


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class message {

        private messageAddressInfo addressInfoField;

        private messageBody bodyField;

        private string nameField;

        private System.DateTime sentDateTimeField;

        private bool sentDateTimeFieldSpecified;

        /// <remarks/>
        public messageAddressInfo addressInfo {
            get {
                return this.addressInfoField;
            }
            set {
                this.addressInfoField = value;
            }
        }

        /// <remarks/>
        public messageBody body {
            get {
                return this.bodyField;
            }
            set {
                this.bodyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime sentDateTime {
            get {
                return this.sentDateTimeField;
            }
            set {
                this.sentDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sentDateTimeSpecified {
            get {
                return this.sentDateTimeFieldSpecified;
            }
            set {
                this.sentDateTimeFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class messageAddressInfo {

        private messageAddressInfoSender senderField;

        /// <remarks/>
        public messageAddressInfoSender sender {
            get {
                return this.senderField;
            }
            set {
                this.senderField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class messageAddressInfoSender {

        private string nameField;

        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class messageBody {

        private messageBodyPayload payloadField;

        private string guidField;

        private bool ackRequiredField;

        private bool ackRequiredFieldSpecified;

        private string messageTypeField;

        /// <remarks/>
        public messageBodyPayload payload {
            get {
                return this.payloadField;
            }
            set {
                this.payloadField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string guid {
            get {
                return this.guidField;
            }
            set {
                this.guidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ackRequired {
            get {
                return this.ackRequiredField;
            }
            set {
                this.ackRequiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ackRequiredSpecified {
            get {
                return this.ackRequiredFieldSpecified;
            }
            set {
                this.ackRequiredFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string messageType {
            get {
                return this.messageTypeField;
            }
            set {
                this.messageTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class messageBodyPayload {

        private int revNumberField;

        private bool revNumberFieldSpecified;

        private int eventIDField;

        private bool eventIDFieldSpecified;

        private int laneIDField;

        private bool laneIDFieldSpecified;

        private int contEventTypeField;

        private bool contEventTypeFieldSpecified;

        private string eventTimeField;

        private string caseNumberField;

        private bool caseNumberFieldSpecified;

        private messageBodyPayloadVehicle vehicleField;

        private messageBodyPayloadCont[] contField;

        private messageBodyPayloadTrailer[] trailerField;

        private messageBodyPayloadVideo videoField;

        private string base64EncodedField;

        /// <remarks/>
        public int RevNumber {
            get {
                return this.revNumberField;
            }
            set {
                this.revNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RevNumberSpecified {
            get {
                return this.revNumberFieldSpecified;
            }
            set {
                this.revNumberFieldSpecified = value;
            }
        }

        /// <remarks/>
        public int EventID {
            get {
                return this.eventIDField;
            }
            set {
                this.eventIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EventIDSpecified {
            get {
                return this.eventIDFieldSpecified;
            }
            set {
                this.eventIDFieldSpecified = value;
            }
        }

        /// <remarks/>
        public int LaneID {
            get {
                return this.laneIDField;
            }
            set {
                this.laneIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LaneIDSpecified {
            get {
                return this.laneIDFieldSpecified;
            }
            set {
                this.laneIDFieldSpecified = value;
            }
        }

        /// <remarks/>
        public int ContEventType {
            get {
                return this.contEventTypeField;
            }
            set {
                this.contEventTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ContEventTypeSpecified {
            get {
                return this.contEventTypeFieldSpecified;
            }
            set {
                this.contEventTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string EventTime {
            get {
                return this.eventTimeField;
            }
            set {
                this.eventTimeField = value;
            }
        }

        /// <remarks/>
        public string CaseNumber {
            get {
                return this.caseNumberField;
            }
            set {
                this.caseNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CaseNumberSpecified {
            get {
                return this.caseNumberFieldSpecified;
            }
            set {
                this.caseNumberFieldSpecified = value;
            }
        }

        /// <remarks/>
        public messageBodyPayloadVehicle Vehicle {
            get {
                return this.vehicleField;
            }
            set {
                this.vehicleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cont")]
        public messageBodyPayloadCont[] Cont {
            get {
                return this.contField;
            }
            set {
                this.contField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Trailer")]
        public messageBodyPayloadTrailer[] Trailer {
            get {
                return this.trailerField;
            }
            set {
                this.trailerField = value;
            }
        }

        /// <remarks/>
        public messageBodyPayloadVideo Video {
            get {
                return this.videoField;
            }
            set {
                this.videoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string base64Encoded {
            get {
                return this.base64EncodedField;
            }
            set {
                this.base64EncodedField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class messageBodyPayloadVehicle {

        private string codeField;

        private string fileNameField;

        private int confidenceField;

        private bool confidenceFieldSpecified;

        /// <remarks/>
        public string Code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }

        /// <remarks/>
        public string FileName {
            get {
                return this.fileNameField;
            }
            set {
                this.fileNameField = value;
            }
        }

        /// <remarks/>
        public int Confidence {
            get {
                return this.confidenceField;
            }
            set {
                this.confidenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ConfidenceSpecified {
            get {
                return this.confidenceFieldSpecified;
            }
            set {
                this.confidenceFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class messageBodyPayloadCont {

        private string codeField;

        private string fileNameField;

        private int confidenceField;

        private bool confidenceFieldSpecified;

        private string sizeTypeField;

        private int sizeTypeConfidenceField;

        private bool sizeTypeConfidenceFieldSpecified;

        private int resultCodeField;

        private bool resultCodeFieldSpecified;

        private string resultTextField;

        private int idField;

        private bool idFieldSpecified;

        /// <remarks/>
        public string Code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }

        /// <remarks/>
        public string FileName {
            get {
                return this.fileNameField;
            }
            set {
                this.fileNameField = value;
            }
        }

        /// <remarks/>
        public int Confidence {
            get {
                return this.confidenceField;
            }
            set {
                this.confidenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ConfidenceSpecified {
            get {
                return this.confidenceFieldSpecified;
            }
            set {
                this.confidenceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string SizeType {
            get {
                return this.sizeTypeField;
            }
            set {
                this.sizeTypeField = value;
            }
        }

        /// <remarks/>
        public int SizeTypeConfidence {
            get {
                return this.sizeTypeConfidenceField;
            }
            set {
                this.sizeTypeConfidenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SizeTypeConfidenceSpecified {
            get {
                return this.sizeTypeConfidenceFieldSpecified;
            }
            set {
                this.sizeTypeConfidenceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public int ResultCode {
            get {
                return this.resultCodeField;
            }
            set {
                this.resultCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResultCodeSpecified {
            get {
                return this.resultCodeFieldSpecified;
            }
            set {
                this.resultCodeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string ResultText {
            get {
                return this.resultTextField;
            }
            set {
                this.resultTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class messageBodyPayloadTrailer {

        private string codeField;

        private string fileNameField;

        private int confidenceField;

        private bool confidenceFieldSpecified;

        private int resultCodeField;

        private bool resultCodeFieldSpecified;

        private string resultTextField;

        private int idField;

        private bool idFieldSpecified;

        /// <remarks/>
        public string Code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }

        /// <remarks/>
        public string FileName {
            get {
                return this.fileNameField;
            }
            set {
                this.fileNameField = value;
            }
        }

        /// <remarks/>
        public int Confidence {
            get {
                return this.confidenceField;
            }
            set {
                this.confidenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ConfidenceSpecified {
            get {
                return this.confidenceFieldSpecified;
            }
            set {
                this.confidenceFieldSpecified = value;
            }
        }

        /// <remarks/>
        public int ResultCode {
            get {
                return this.resultCodeField;
            }
            set {
                this.resultCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResultCodeSpecified {
            get {
                return this.resultCodeFieldSpecified;
            }
            set {
                this.resultCodeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string ResultText {
            get {
                return this.resultTextField;
            }
            set {
                this.resultTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class messageBodyPayloadVideo {

        private string leftField;

        private string rightField;

        private string topField;

        private string rearField;

        /// <remarks/>
        public string Left {
            get {
                return this.leftField;
            }
            set {
                this.leftField = value;
            }
        }

        /// <remarks/>
        public string Right {
            get {
                return this.rightField;
            }
            set {
                this.rightField = value;
            }
        }

        /// <remarks/>
        public string Top {
            get {
                return this.topField;
            }
            set {
                this.topField = value;
            }
        }

        /// <remarks/>
        public string Rear {
            get {
                return this.rearField;
            }
            set {
                this.rearField = value;
            }
        }
    }
}