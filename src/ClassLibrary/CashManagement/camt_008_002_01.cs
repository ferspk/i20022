
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



namespace i20022.camt00800201
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id camt.008.002.01 name RequestToCancelPayment from Cash Management business area.
    /// Repository:R 6.8.0.1 v492 - 4 July 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.008.002.01")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.008.002.01", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>camt00800201</b> (camt 00800201) of type camt00800201.
        /// </summary>
        [XmlElementAttribute("camt.008.002.01", Order=0)]
        public camt00800201 camt00800201;
    }
    
    /// <summary>
    /// Class <b>camt00800201</b> (camt 00800201).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(TypeName="camt.008.002.01", Namespace="urn:iso:std:iso:20022:tech:xsd:camt.008.002.01")]
    public class camt00800201
    {
        
        /// <summary>
        /// Element <b>Assgnmt</b> (Assignment) of type CaseAssignment.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public CaseAssignment Assgnmt;
        
        /// <summary>
        /// Element <b>Case</b> (Case) of type Case.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public Case Case;
        
        /// <summary>
        /// Element <b>Undrlyg</b> (Underlying) of type PaymentInstructionExtract.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PaymentInstructionExtract Undrlyg;
        
        /// <summary>
        /// Element <b>Justfn</b> (Justification) of type DebitAuthorisationDetails.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public DebitAuthorisationDetails Justfn;
    }
    
    /// <summary>
    /// Class <b>CaseAssignment</b> (Case Assignment).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.008.002.01")]
    public class CaseAssignment
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>Assgnr</b> (Assigner) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Assgnr;
        
        /// <summary>
        /// Element <b>Assgne</b> (Assignee) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Assgne;
        
        /// <summary>
        /// Element <b>CreDtTm</b> (Creation Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public System.DateTime CreDtTm;
    }
    
    /// <summary>
    /// Class <b>DebitAuthorisationDetails</b> (Debit Authorisation Details).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.008.002.01")]
    public class DebitAuthorisationDetails
    {
        
        /// <summary>
        /// Element <b>CxlRsn</b> (Cancellation Reason) of type CancellationReason1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public CancellationReason1Code CxlRsn;
        
        /// <summary>
        /// Element <b>AmtToDbt</b> (Amount To Debit) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public CurrencyAndAmount AmtToDbt;
        
        /// <summary>
        /// Element <b>ValDtToDbt</b> (Value Date To Debit) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=2)]
        public System.DateTime ValDtToDbt;
        
        /// <summary>
        /// Element <b>ValDtToDbtSpecified</b> (Value Date To Debit Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValDtToDbtSpecified;
    }
    
    /// <summary>
    /// Enumeration <b>CancellationReason1Code</b> (Cancellation Reason 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.008.002.01")]
    public enum CancellationReason1Code
    {
        
        /// <summary>
        /// <b>CUST - Custodial Account</b>.
        /// </summary>
        CUST,
        
        /// <summary>
        /// <b>DUPL - Duplicate Payment</b>.
        /// </summary>
        DUPL,
        
        /// <summary>
        /// <b>AGNT - Incorrect Agent</b>.
        /// </summary>
        AGNT,
        
        /// <summary>
        /// <b>CURR - Incorrect Currency</b>.
        /// </summary>
        CURR,
        
        /// <summary>
        /// <b>UPAY - Undue Payment</b>.
        /// </summary>
        UPAY,
    }
    
    /// <summary>
    /// Class <b>CurrencyAndAmount</b> (Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.008.002.01")]
    public class CurrencyAndAmount
    {
        
        /// <summary>
        /// Element <b>Ccy</b> (Currency) of type string.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Ccy;
        
        /// <summary>
        /// Element <b>Value</b> (Value) of type decimal.
        /// </summary>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value;
    }
    
    /// <summary>
    /// Class <b>PaymentInstructionExtract</b> (Payment Instruction Extract).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.008.002.01")]
    public class PaymentInstructionExtract
    {
        
        /// <summary>
        /// Element <b>AssgnrInstrId</b> (Assigner Instruction Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string AssgnrInstrId;
        
        /// <summary>
        /// Element <b>AssgneInstrId</b> (Assignee Instruction Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AssgneInstrId;
        
        /// <summary>
        /// Element <b>CcyAmt</b> (Currency Amount) of type CurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public CurrencyAndAmount CcyAmt;
        
        /// <summary>
        /// Element <b>ValDt</b> (Value Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public System.DateTime ValDt;
        
        /// <summary>
        /// Element <b>ValDtSpecified</b> (Value Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValDtSpecified;
    }
    
    /// <summary>
    /// Class <b>Case</b> (Case).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.008.002.01")]
    public class Case
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>Cretr</b> (Creator) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Cretr;
        
        /// <summary>
        /// Element <b>ReopCaseIndctn</b> (Reopen Case Indication) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public bool ReopCaseIndctn;
        
        /// <summary>
        /// Element <b>ReopCaseIndctnSpecified</b> (Reopen Case Indication Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReopCaseIndctnSpecified;
    }
}
