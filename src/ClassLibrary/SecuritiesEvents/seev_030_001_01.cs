
//                                      ______    ____   
//                                     |____  | "|__  |  
//                                      _   | |     | |  
//                                     | |  | |   __| |  
//                                     |_|  |_|  |_____| 
//                                                       
//  ---------------------------------------------------  
// |     _   ____     ___     ___    ____    ____      | 
// |    (_) |___ \   / _ \   / _ \  |___ \  |___ \     | 
// |    | |   __) | | | | | | | | |   __) |   __) |    | 
// |    | |  / __/  | |_| | | |_| |  / __/   / __/     | 
// |    |_| |_____|  \___/   \___/  |_____| |_____|    | 
// |                                                   | 
// |    AN ISO 20022 OPEN-SOURCE .NET CLASS LIBRARY    | 
// |            FOR MESSAGING APPLICATIONS             | 
// |                                                   | 
// |        Copyright (C) 2008 Mauricio Leventer       | 
// |                mleventer@i20022.com               | 
// |                                                   | 
//  ---------------------------------------------------  
//                                                       
// L I C E N S E                                         
//                                                       
// This program is free software; you can redistribute it
// and/or modify it under the terms of the GNU General   
// Public License as published by the Free Software      
// Foundation; either version 2 of the License, or (at   
// your option) any later version.                       
//                                                       
// This program is distributed in the hope that it will  
// be useful, but WITHOUT ANY WARRANTY; without even the 
// implied warranty of MERCHANTABILITY or FITNESS FOR A  
// PARTICULAR PURPOSE. See the GNU General Public License
// for more details.                                     
//                                                       
// You should have received a copy of the GNU General    
// Public License along with this program; if not, write 
// to the Free Software Foundation, Inc.,                
// 59 Temple Place, Suite 330, Boston, MA                
// 02111-1307 USA.                                       
//
//
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml.Serialization;



namespace i20022.seev03000101
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id seev.030.001.01 name AgentCADeactivationStatusAdviceV01 from Securities Events business area.
    /// Repository:R 6.8.0.1 v492 - 4 July 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.030.001.01")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.030.001.01", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>AgtCADeactvtnStsAdvc</b> (Agent CA Deactivation Status Advice) of type AgentCADeactivationStatusAdviceV01.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AgentCADeactivationStatusAdviceV01 AgtCADeactvtnStsAdvc;
    }
    
    /// <summary>
    /// Class <b>AgentCADeactivationStatusAdviceV01</b> (Agent CA Deactivation Status Advice V01).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.030.001.01")]
    public class AgentCADeactivationStatusAdviceV01
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type DocumentIdentification8.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DocumentIdentification8 Id;
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type DocumentIdentification8.
        /// </summary>
        [XmlElementAttribute("AgtCADeactvtnCxlReqId", typeof(DocumentIdentification8), Order=1)]
        [XmlElementAttribute("AgtCADeactvtnInstrId", typeof(DocumentIdentification8), Order=1)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public DocumentIdentification8 Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;
        
        /// <summary>
        /// Element <b>CorpActnGnlInf</b> (Corporate Action General Information) of type CorporateActionInformation1.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public CorporateActionInformation1 CorpActnGnlInf;
        
        /// <summary>
        /// Element <b>Items</b> (Items) of type array of object.
        /// [XOR] This element can be:
        /// DeactvtnCxlReqSts (Deactivation Cancellation Request Status) of type CorporateActionDeactivationCancellationStatus1Choice 
        /// DeactvtnInstrSts (Deactivation Instruction Status) of type CorporateActionDeactivationInstructionStatus1 
        /// </summary>
        [XmlElementAttribute("DeactvtnCxlReqSts", typeof(CorporateActionDeactivationCancellationStatus1Choice), Order=4)]
        [XmlElementAttribute("DeactvtnInstrSts", typeof(CorporateActionDeactivationInstructionStatus1), Order=4)]
        public object[] Items;
    }
    
    /// <summary>
    /// Class <b>DocumentIdentification8</b> (Document Identification 8).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.030.001.01")]
    public class DocumentIdentification8
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>CreDtTm</b> (Creation Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public System.DateTime CreDtTm;
        
        /// <summary>
        /// Element <b>CreDtTmSpecified</b> (Creation Date Time Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreDtTmSpecified;
    }
    
    /// <summary>
    /// Class <b>RejectionReason7FormatChoice</b> (Rejection Reason 7Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.030.001.01")]
    public class RejectionReason7FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type RejectionReason7Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(RejectionReason7Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>RejectionReason7Code</b> (Rejection Reason 7Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.030.001.01")]
    public enum RejectionReason7Code
    {
        
        /// <summary>
        /// <b>DEAC - ?undefined?</b>.
        /// </summary>
        DEAC,
        
        /// <summary>
        /// <b>FAIL - ?undefined?</b>.
        /// </summary>
        FAIL,
        
        /// <summary>
        /// <b>PDEA - ?undefined?</b>.
        /// </summary>
        PDEA,
        
        /// <summary>
        /// <b>INID - Insufficient Investor Data</b>.
        /// </summary>
        INID,
        
        /// <summary>
        /// <b>REFI - ?undefined?</b>.
        /// </summary>
        REFI,
        
        /// <summary>
        /// <b>AGIN - ?undefined?</b>.
        /// </summary>
        AGIN,
        
        /// <summary>
        /// <b>SAID - ?undefined?</b>.
        /// </summary>
        SAID,
        
        /// <summary>
        /// <b>DEAO - ?undefined?</b>.
        /// </summary>
        DEAO,
        
        /// <summary>
        /// <b>INET - ?undefined?</b>.
        /// </summary>
        INET,
        
        /// <summary>
        /// <b>INUS - ?undefined?</b>.
        /// </summary>
        INUS,
        
        /// <summary>
        /// <b>INPT - ?undefined?</b>.
        /// </summary>
        INPT,
        
        /// <summary>
        /// <b>INMV - ?undefined?</b>.
        /// </summary>
        INMV,
        
        /// <summary>
        /// <b>INDE - ?undefined?</b>.
        /// </summary>
        INDE,
        
        /// <summary>
        /// <b>INDT - ?undefined?</b>.
        /// </summary>
        INDT,
    }
    
    /// <summary>
    /// Class <b>GenericIdentification13</b> (Generic Identification 13).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.030.001.01")]
    public class GenericIdentification13
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>SchmeNm</b> (Scheme Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string SchmeNm;
        
        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Issr;
    }
    
    /// <summary>
    /// Class <b>CorporateActionDeactivationCancellationRejectionStatus1</b> (Corporate Action Deactivation Cancellation Rejection Status 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.030.001.01")]
    public class CorporateActionDeactivationCancellationRejectionStatus1
    {
        
        /// <summary>
        /// Element <b>Rsn</b> (Reason) of type array of RejectionReason7FormatChoice.
        /// </summary>
        [XmlElementAttribute("Rsn", Order=0)]
        public RejectionReason7FormatChoice[] Rsn;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Class <b>ProcessedStatus2FormatChoice</b> (Processed Status 2Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.030.001.01")]
    public class ProcessedStatus2FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type ProcessedStatus2Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(ProcessedStatus2Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>ProcessedStatus2Code</b> (Processed Status 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.030.001.01")]
    public enum ProcessedStatus2Code
    {
        
        /// <summary>
        /// <b>RECE - Received</b>.
        /// </summary>
        RECE,
        
        /// <summary>
        /// <b>COMP - Complete</b>.
        /// </summary>
        COMP,
    }
    
    /// <summary>
    /// Class <b>CorporateActionDeactivationCancellationProcessingStatus1</b> (Corporate Action Deactivation Cancellation Processing Status 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.030.001.01")]
    public class CorporateActionDeactivationCancellationProcessingStatus1
    {
        
        /// <summary>
        /// Element <b>Sts</b> (Status) of type ProcessedStatus2FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ProcessedStatus2FormatChoice Sts;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Class <b>CorporateActionDeactivationCancellationStatus1Choice</b> (Corporate Action Deactivation Cancellation Status 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.030.001.01")]
    public class CorporateActionDeactivationCancellationStatus1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// PrcdSts (Processed Status) of type CorporateActionDeactivationCancellationProcessingStatus1 
        /// RjctdSts (Rejected Status) of type CorporateActionDeactivationCancellationRejectionStatus1 
        /// </summary>
        [XmlElementAttribute("PrcdSts", typeof(CorporateActionDeactivationCancellationProcessingStatus1), Order=0)]
        [XmlElementAttribute("RjctdSts", typeof(CorporateActionDeactivationCancellationRejectionStatus1), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>RejectionReason12FormatChoice</b> (Rejection Reason 12 Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.030.001.01")]
    public class RejectionReason12FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type RejectionReason12Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(RejectionReason12Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>RejectionReason12Code</b> (Rejection Reason 12 Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.030.001.01")]
    public enum RejectionReason12Code
    {
        
        /// <summary>
        /// <b>DEAC - ?undefined?</b>.
        /// </summary>
        DEAC,
        
        /// <summary>
        /// <b>FAIL - ?undefined?</b>.
        /// </summary>
        FAIL,
        
        /// <summary>
        /// <b>SAME - ?undefined?</b>.
        /// </summary>
        SAME,
        
        /// <summary>
        /// <b>REFI - ?undefined?</b>.
        /// </summary>
        REFI,
        
        /// <summary>
        /// <b>AGIN - ?undefined?</b>.
        /// </summary>
        AGIN,
        
        /// <summary>
        /// <b>MAIN - ?undefined?</b>.
        /// </summary>
        MAIN,
        
        /// <summary>
        /// <b>OPTI - ?undefined?</b>.
        /// </summary>
        OPTI,
        
        /// <summary>
        /// <b>PEDA - ?undefined?</b>.
        /// </summary>
        PEDA,
        
        /// <summary>
        /// <b>NORO - ?undefined?</b>.
        /// </summary>
        NORO,
        
        /// <summary>
        /// <b>INET - ?undefined?</b>.
        /// </summary>
        INET,
        
        /// <summary>
        /// <b>INUS - ?undefined?</b>.
        /// </summary>
        INUS,
        
        /// <summary>
        /// <b>INPT - ?undefined?</b>.
        /// </summary>
        INPT,
        
        /// <summary>
        /// <b>INMV - ?undefined?</b>.
        /// </summary>
        INMV,
        
        /// <summary>
        /// <b>SAID - ?undefined?</b>.
        /// </summary>
        SAID,
        
        /// <summary>
        /// <b>MICA - ?undefined?</b>.
        /// </summary>
        MICA,
        
        /// <summary>
        /// <b>NOAP - ?undefined?</b>.
        /// </summary>
        NOAP,
    }
    
    /// <summary>
    /// Class <b>CorporateActionDeactivationInstructionRejectionStatus1</b> (Corporate Action Deactivation Instruction Rejection Status 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.030.001.01")]
    public class CorporateActionDeactivationInstructionRejectionStatus1
    {
        
        /// <summary>
        /// Element <b>Rsn</b> (Reason) of type array of RejectionReason12FormatChoice.
        /// </summary>
        [XmlElementAttribute("Rsn", Order=0)]
        public RejectionReason12FormatChoice[] Rsn;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Class <b>ProcessedStatus6FormatChoice</b> (Processed Status 6Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.030.001.01")]
    public class ProcessedStatus6FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type ProcessedStatus6Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(ProcessedStatus6Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>ProcessedStatus6Code</b> (Processed Status 6Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.030.001.01")]
    public enum ProcessedStatus6Code
    {
        
        /// <summary>
        /// <b>RECE - Received</b>.
        /// </summary>
        RECE,
        
        /// <summary>
        /// <b>DEAC - ?undefined?</b>.
        /// </summary>
        DEAC,
        
        /// <summary>
        /// <b>COMP - Complete</b>.
        /// </summary>
        COMP,
    }
    
    /// <summary>
    /// Class <b>CorporateActionDeactivationInstructionProcessingStatus1</b> (Corporate Action Deactivation Instruction Processing Status 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.030.001.01")]
    public class CorporateActionDeactivationInstructionProcessingStatus1
    {
        
        /// <summary>
        /// Element <b>Sts</b> (Status) of type ProcessedStatus6FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ProcessedStatus6FormatChoice Sts;
        
        /// <summary>
        /// Element <b>AddtlInf</b> (Additional Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AddtlInf;
    }
    
    /// <summary>
    /// Class <b>CorporateActionOption1FormatChoice</b> (Corporate Action Option 1Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.030.001.01")]
    public class CorporateActionOption1FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type CorporateActionOptionType1Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(CorporateActionOptionType1Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>CorporateActionOptionType1Code</b> (Corporate Action Option Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.030.001.01")]
    public enum CorporateActionOptionType1Code
    {
        
        /// <summary>
        /// <b>BSPL - Bonus Share Plan</b>.
        /// </summary>
        BSPL,
        
        /// <summary>
        /// <b>BUYA - Buy Up</b>.
        /// </summary>
        BUYA,
        
        /// <summary>
        /// <b>CASE - Cash and Securities</b>.
        /// </summary>
        CASE,
        
        /// <summary>
        /// <b>CASH - Cash</b>.
        /// </summary>
        CASH,
        
        /// <summary>
        /// <b>CEXC - Consent and Exchange</b>.
        /// </summary>
        CEXC,
        
        /// <summary>
        /// <b>CTEN - Consent and Tender</b>.
        /// </summary>
        CTEN,
        
        /// <summary>
        /// <b>CONN - Consent Denied</b>.
        /// </summary>
        CONN,
        
        /// <summary>
        /// <b>CONY - Consent Granted</b>.
        /// </summary>
        CONY,
        
        /// <summary>
        /// <b>EXER - Exercise</b>.
        /// </summary>
        EXER,
        
        /// <summary>
        /// <b>LAPS - Lapse</b>.
        /// </summary>
        LAPS,
        
        /// <summary>
        /// <b>MPUT - Retain</b>.
        /// </summary>
        MPUT,
        
        /// <summary>
        /// <b>NOAC - No Action</b>.
        /// </summary>
        NOAC,
        
        /// <summary>
        /// <b>OFFR - Offer / Proposed Rate</b>.
        /// </summary>
        OFFR,
        
        /// <summary>
        /// <b>OVER - Normal Processing Period Lapsed / Oversubscribe</b>.
        /// </summary>
        OVER,
        
        /// <summary>
        /// <b>SECU - Security Charge / Securities Option</b>.
        /// </summary>
        SECU,
        
        /// <summary>
        /// <b>SLLE - Sell Entitlement</b>.
        /// </summary>
        SLLE,
        
        /// <summary>
        /// <b>SPLI - Split Instruction</b>.
        /// </summary>
        SPLI,
        
        /// <summary>
        /// <b>NOQU - Non Qualified Investor</b>.
        /// </summary>
        NOQU,
        
        /// <summary>
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,
        
        /// <summary>
        /// <b>QINV - Qualified Investor</b>.
        /// </summary>
        QINV,
    }
    
    /// <summary>
    /// Class <b>CorporateActionDeactivationInstructionStatus1</b> (Corporate Action Deactivation Instruction Status 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.030.001.01")]
    public class CorporateActionDeactivationInstructionStatus1
    {
        
        /// <summary>
        /// Element <b>OptnTp</b> (Option Type) of type CorporateActionOption1FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public CorporateActionOption1FormatChoice OptnTp;
        
        /// <summary>
        /// Element <b>OptnNb</b> (Option Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string OptnNb;
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// PrcdSts (Processed Status) of type CorporateActionDeactivationInstructionProcessingStatus1 
        /// RjctdSts (Rejected Status) of type CorporateActionDeactivationInstructionRejectionStatus1 
        /// </summary>
        [XmlElementAttribute("PrcdSts", typeof(CorporateActionDeactivationInstructionProcessingStatus1), Order=2)]
        [XmlElementAttribute("RjctdSts", typeof(CorporateActionDeactivationInstructionRejectionStatus1), Order=2)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>AlternateSecurityIdentification3</b> (Alternate Security Identification 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.030.001.01")]
    public class AlternateSecurityIdentification3
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type string.
        /// </summary>
        [XmlElementAttribute("DmstIdSrc", typeof(string), Order=1)]
        [XmlElementAttribute("PrtryIdSrc", typeof(string), Order=1)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType1.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType1</b> (Item Choice Type 1).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.030.001.01", IncludeInSchema=false)]
    public enum ItemChoiceType1
    {
        
        /// <summary>
        /// <b>DmstIdSrc - Domestic Identification Source</b>.
        /// </summary>
        DmstIdSrc,
        
        /// <summary>
        /// <b>PrtryIdSrc - Proprietary Identification Source</b>.
        /// </summary>
        PrtryIdSrc,
    }
    
    /// <summary>
    /// Class <b>SecurityIdentification7</b> (Security Identification 7).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.030.001.01")]
    public class SecurityIdentification7
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// ISIN (ISIN) of type string 
        /// OthrId (Other Identification) of type AlternateSecurityIdentification3 
        /// </summary>
        [XmlElementAttribute("ISIN", typeof(string), Order=0)]
        [XmlElementAttribute("OthrId", typeof(AlternateSecurityIdentification3), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>Desc</b> (Description) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Desc;
    }
    
    /// <summary>
    /// Class <b>FinancialInstrumentDescription3</b> (Financial Instrument Description 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.030.001.01")]
    public class FinancialInstrumentDescription3
    {
        
        /// <summary>
        /// Element <b>SctyId</b> (Security Identification) of type SecurityIdentification7.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public SecurityIdentification7 SctyId;
        
        /// <summary>
        /// Element <b>PlcOfListg</b> (Place Of Listing) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string PlcOfListg;
        
        /// <summary>
        /// Element <b>SfkpgPlc</b> (Safekeeping Place) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PartyIdentification2Choice SfkpgPlc;
    }
    
    /// <summary>
    /// Class <b>PartyIdentification2Choice</b> (Party Identification 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.030.001.01")]
    public class PartyIdentification2Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// BICOrBEI (BIC Or BEI) of type string 
        /// NmAndAdr (Name And Address) of type NameAndAddress5 
        /// PrtryId (Proprietary Identification) of type GenericIdentification1 
        /// </summary>
        [XmlElementAttribute("BICOrBEI", typeof(string), Order=0)]
        [XmlElementAttribute("NmAndAdr", typeof(NameAndAddress5), Order=0)]
        [XmlElementAttribute("PrtryId", typeof(GenericIdentification1), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>NameAndAddress5</b> (Name And Address 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.030.001.01")]
    public class NameAndAddress5
    {
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Nm;
        
        /// <summary>
        /// Element <b>Adr</b> (Address) of type PostalAddress1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PostalAddress1 Adr;
    }
    
    /// <summary>
    /// Class <b>PostalAddress1</b> (Postal Address 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.030.001.01")]
    public class PostalAddress1
    {
        
        /// <summary>
        /// Element <b>AdrTp</b> (Address Type) of type AddressType2Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AddressType2Code AdrTp;
        
        /// <summary>
        /// Element <b>AdrTpSpecified</b> (Address Type Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AdrTpSpecified;
        
        /// <summary>
        /// Element <b>AdrLine</b> (Address Line) of type array of string.
        /// </summary>
        [XmlElementAttribute("AdrLine", Order=1)]
        public string[] AdrLine;
        
        /// <summary>
        /// Element <b>StrtNm</b> (Street Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string StrtNm;
        
        /// <summary>
        /// Element <b>BldgNb</b> (Building Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string BldgNb;
        
        /// <summary>
        /// Element <b>PstCd</b> (Post Code) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string PstCd;
        
        /// <summary>
        /// Element <b>TwnNm</b> (Town Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public string TwnNm;
        
        /// <summary>
        /// Element <b>CtrySubDvsn</b> (Country Sub Division) of type string.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public string CtrySubDvsn;
        
        /// <summary>
        /// Element <b>Ctry</b> (Country) of type string.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public string Ctry;
    }
    
    /// <summary>
    /// Enumeration <b>AddressType2Code</b> (Address Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.030.001.01")]
    public enum AddressType2Code
    {
        
        /// <summary>
        /// <b>ADDR - Postal</b>.
        /// </summary>
        ADDR,
        
        /// <summary>
        /// <b>PBOX - POBox</b>.
        /// </summary>
        PBOX,
        
        /// <summary>
        /// <b>HOME - Residential</b>.
        /// </summary>
        HOME,
        
        /// <summary>
        /// <b>BIZZ - Business</b>.
        /// </summary>
        BIZZ,
        
        /// <summary>
        /// <b>MLTO - Mail To</b>.
        /// </summary>
        MLTO,
        
        /// <summary>
        /// <b>DLVY - Delivery To</b>.
        /// </summary>
        DLVY,
    }
    
    /// <summary>
    /// Class <b>GenericIdentification1</b> (Generic Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.030.001.01")]
    public class GenericIdentification1
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>SchmeNm</b> (Scheme Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string SchmeNm;
        
        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Issr;
    }
    
    /// <summary>
    /// Class <b>CorporateActionEventProcessingType1FormatChoice</b> (Corporate Action Event Processing Type 1Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.030.001.01")]
    public class CorporateActionEventProcessingType1FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type CorporateActionEventProcessingType1Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(CorporateActionEventProcessingType1Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>CorporateActionEventProcessingType1Code</b> (Corporate Action Event Processing Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.030.001.01")]
    public enum CorporateActionEventProcessingType1Code
    {
        
        /// <summary>
        /// <b>GENL - General</b>.
        /// </summary>
        GENL,
        
        /// <summary>
        /// <b>DISN - CA Results in a Distribution</b>.
        /// </summary>
        DISN,
        
        /// <summary>
        /// <b>REOR - CA Results in a Reorganisation</b>.
        /// </summary>
        REOR,
    }
    
    /// <summary>
    /// Class <b>CorporateActionMandatoryVoluntary1FormatChoice</b> (Corporate Action Mandatory Voluntary 1Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.030.001.01")]
    public class CorporateActionMandatoryVoluntary1FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type CorporateActionMandatoryVoluntary1Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(CorporateActionMandatoryVoluntary1Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>CorporateActionMandatoryVoluntary1Code</b> (Corporate Action Mandatory Voluntary 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.030.001.01")]
    public enum CorporateActionMandatoryVoluntary1Code
    {
        
        /// <summary>
        /// <b>MAND - Mandatory CA Event; No Instruction Required</b>.
        /// </summary>
        MAND,
        
        /// <summary>
        /// <b>CHOS - Mandatory CA Event; Instruction Required</b>.
        /// </summary>
        CHOS,
        
        /// <summary>
        /// <b>VOLU - Voluntary CA Event; Instruction Required to Participate</b>.
        /// </summary>
        VOLU,
    }
    
    /// <summary>
    /// Class <b>CorporateActionEventType2FormatChoice</b> (Corporate Action Event Type 2Format Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.030.001.01")]
    public class CorporateActionEventType2FormatChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type CorporateActionEventType2Code 
        /// Prtry (Proprietary) of type GenericIdentification13 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(CorporateActionEventType2Code), Order=0)]
        [XmlElementAttribute("Prtry", typeof(GenericIdentification13), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>CorporateActionEventType2Code</b> (Corporate Action Event Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.030.001.01")]
    public enum CorporateActionEventType2Code
    {
        
        /// <summary>
        /// <b>ACTV - Active</b>.
        /// </summary>
        ACTV,
        
        /// <summary>
        /// <b>ATTI - Attachment</b>.
        /// </summary>
        ATTI,
        
        /// <summary>
        /// <b>BIDS - Repurchase Offer/Issuer Bid/Reverse Rights</b>.
        /// </summary>
        BIDS,
        
        /// <summary>
        /// <b>BONU - Bonus Issue / Capitalisation Issue</b>.
        /// </summary>
        BONU,
        
        /// <summary>
        /// <b>BPUT - Put Redemption</b>.
        /// </summary>
        BPUT,
        
        /// <summary>
        /// <b>BRUP - Bankruptcy</b>.
        /// </summary>
        BRUP,
        
        /// <summary>
        /// <b>CAPG - Capital Gains Distribution</b>.
        /// </summary>
        CAPG,
        
        /// <summary>
        /// <b>CAPI - ?undefined?</b>.
        /// </summary>
        CAPI,
        
        /// <summary>
        /// <b>CERT - Certificate required / Non-US TEFRA D Certification</b>.
        /// </summary>
        CERT,
        
        /// <summary>
        /// <b>CHAN - Change</b>.
        /// </summary>
        CHAN,
        
        /// <summary>
        /// <b>CLSA - Class Action/Proposed Settlement</b>.
        /// </summary>
        CLSA,
        
        /// <summary>
        /// <b>CONS - Consent</b>.
        /// </summary>
        CONS,
        
        /// <summary>
        /// <b>CONV - Convert / Conversion</b>.
        /// </summary>
        CONV,
        
        /// <summary>
        /// <b>COOP - Company Option</b>.
        /// </summary>
        COOP,
        
        /// <summary>
        /// <b>DECR - Decrease In Value</b>.
        /// </summary>
        DECR,
        
        /// <summary>
        /// <b>DETI - Detachment</b>.
        /// </summary>
        DETI,
        
        /// <summary>
        /// <b>DFLT - Bond Default</b>.
        /// </summary>
        DFLT,
        
        /// <summary>
        /// <b>DLST - Delisted</b>.
        /// </summary>
        DLST,
        
        /// <summary>
        /// <b>DRAW - Drawn</b>.
        /// </summary>
        DRAW,
        
        /// <summary>
        /// <b>DRIP - Dividend Reinvestment</b>.
        /// </summary>
        DRIP,
        
        /// <summary>
        /// <b>DSCL - Disclosure</b>.
        /// </summary>
        DSCL,
        
        /// <summary>
        /// <b>DTCH - Dutch Auction</b>.
        /// </summary>
        DTCH,
        
        /// <summary>
        /// <b>DVCA - Cash Dividend</b>.
        /// </summary>
        DVCA,
        
        /// <summary>
        /// <b>DVOP - Dividend Option</b>.
        /// </summary>
        DVOP,
        
        /// <summary>
        /// <b>DVSC - Scrip Dividend/Payment</b>.
        /// </summary>
        DVSC,
        
        /// <summary>
        /// <b>DVSE - Stock Dividend</b>.
        /// </summary>
        DVSE,
        
        /// <summary>
        /// <b>EXOF - Exchange Offer</b>.
        /// </summary>
        EXOF,
        
        /// <summary>
        /// <b>EXRI - Call On Rights</b>.
        /// </summary>
        EXRI,
        
        /// <summary>
        /// <b>EXTM - Maturity Extension</b>.
        /// </summary>
        EXTM,
        
        /// <summary>
        /// <b>EXWA - Warrant Exercise</b>.
        /// </summary>
        EXWA,
        
        /// <summary>
        /// <b>INCR - Increase in Value</b>.
        /// </summary>
        INCR,
        
        /// <summary>
        /// <b>INTR - Intermediary / Interest Payment</b>.
        /// </summary>
        INTR,
        
        /// <summary>
        /// <b>LIQU - Liquidation</b>.
        /// </summary>
        LIQU,
        
        /// <summary>
        /// <b>MCAL - Full Call/Early Redemption</b>.
        /// </summary>
        MCAL,
        
        /// <summary>
        /// <b>MRGR - Merger</b>.
        /// </summary>
        MRGR,
        
        /// <summary>
        /// <b>ODLT - Odd Lot Sale/Purchase</b>.
        /// </summary>
        ODLT,
        
        /// <summary>
        /// <b>PARI - Pari Passu</b>.
        /// </summary>
        PARI,
        
        /// <summary>
        /// <b>PCAL - Partial Redemption With Reduction of Nominal Value</b>.
        /// </summary>
        PCAL,
        
        /// <summary>
        /// <b>PDEF - Partial Defeasance/Pre-funding</b>.
        /// </summary>
        PDEF,
        
        /// <summary>
        /// <b>PINK - Pay In Kind</b>.
        /// </summary>
        PINK,
        
        /// <summary>
        /// <b>PLAC - Place of Incorporation</b>.
        /// </summary>
        PLAC,
        
        /// <summary>
        /// <b>PPMT - Instalment Call</b>.
        /// </summary>
        PPMT,
        
        /// <summary>
        /// <b>PRED - Partial Redemption Without Reduction of Nominal Value</b>.
        /// </summary>
        PRED,
        
        /// <summary>
        /// <b>PRII - Interest Payment with Principle</b>.
        /// </summary>
        PRII,
        
        /// <summary>
        /// <b>PRIO - Priority Issue</b>.
        /// </summary>
        PRIO,
        
        /// <summary>
        /// <b>REDM - Redemption</b>.
        /// </summary>
        REDM,
        
        /// <summary>
        /// <b>REDO - Redenomination</b>.
        /// </summary>
        REDO,
        
        /// <summary>
        /// <b>REMK - Remarketing Agreement</b>.
        /// </summary>
        REMK,
        
        /// <summary>
        /// <b>RHDI - Rights Distribution</b>.
        /// </summary>
        RHDI,
        
        /// <summary>
        /// <b>RHTS - Rights Issue/Subscription Rights/Rights Offer</b>.
        /// </summary>
        RHTS,
        
        /// <summary>
        /// <b>SHPR - Shares Premium Dividend</b>.
        /// </summary>
        SHPR,
        
        /// <summary>
        /// <b>SMAL - ?undefined?</b>.
        /// </summary>
        SMAL,
        
        /// <summary>
        /// <b>SOFF - Spin Off</b>.
        /// </summary>
        SOFF,
        
        /// <summary>
        /// <b>SPLF - Stock Split</b>.
        /// </summary>
        SPLF,
        
        /// <summary>
        /// <b>SPLR - Reverse Stock Split</b>.
        /// </summary>
        SPLR,
        
        /// <summary>
        /// <b>SUSP - Suspicious Payment</b>.
        /// </summary>
        SUSP,
        
        /// <summary>
        /// <b>TEND - Tender</b>.
        /// </summary>
        TEND,
        
        /// <summary>
        /// <b>TREC - Tax Reclaim</b>.
        /// </summary>
        TREC,
        
        /// <summary>
        /// <b>WRTH - Worthless</b>.
        /// </summary>
        WRTH,
        
        /// <summary>
        /// <b>WTRC - ?undefined?</b>.
        /// </summary>
        WTRC,
        
        /// <summary>
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,
    }
    
    /// <summary>
    /// Class <b>CorporateActionInformation1</b> (Corporate Action Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.030.001.01")]
    public class CorporateActionInformation1
    {
        
        /// <summary>
        /// Element <b>AgtId</b> (Agent Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PartyIdentification2Choice AgtId;
        
        /// <summary>
        /// Element <b>IssrCorpActnId</b> (Issuer Corporate Action Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string IssrCorpActnId;
        
        /// <summary>
        /// Element <b>CorpActnPrcgId</b> (Corporate Action Processing Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string CorpActnPrcgId;
        
        /// <summary>
        /// Element <b>EvtTp</b> (Event Type) of type CorporateActionEventType2FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public CorporateActionEventType2FormatChoice EvtTp;
        
        /// <summary>
        /// Element <b>MndtryVlntryEvtTp</b> (Mandatory Voluntary Event Type) of type CorporateActionMandatoryVoluntary1FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public CorporateActionMandatoryVoluntary1FormatChoice MndtryVlntryEvtTp;
        
        /// <summary>
        /// Element <b>EvtPrcgTp</b> (Event Processing Type) of type CorporateActionEventProcessingType1FormatChoice.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public CorporateActionEventProcessingType1FormatChoice EvtPrcgTp;
        
        /// <summary>
        /// Element <b>UndrlygScty</b> (Underlying Security) of type FinancialInstrumentDescription3.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public FinancialInstrumentDescription3 UndrlygScty;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType</b> (Item Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.030.001.01", IncludeInSchema=false)]
    public enum ItemChoiceType
    {
        
        /// <summary>
        /// <b>AgtCADeactvtnCxlReqId - Agent CA Deactivation Cancellation Request Identification</b>.
        /// </summary>
        AgtCADeactvtnCxlReqId,
        
        /// <summary>
        /// <b>AgtCADeactvtnInstrId - Agent CA Deactivation Instruction Identification</b>.
        /// </summary>
        AgtCADeactvtnInstrId,
    }
}
