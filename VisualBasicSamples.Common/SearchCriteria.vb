'  Copyright:   Copyright 2013 MYOB Technology Pty Ltd. All rights reserved.
'  Website:     http://www.myob.com
'  Author:      MYOB
'  E-mail:      info@myob.com
'
' Documentation, code and sample applications provided by MYOB Australia are for 
' information purposes only. MYOB Technology Pty Ltd and its suppliers make no 
' warranties, either express or implied, in this document. 
'
' Information in this document or code, including website references, is subject
' to change without notice. Unless otherwise noted, the example companies, 
' organisations, products, domain names, email addresses, people, places, and 
' events are fictitious. 
'
' The entire risk of the use of this documentation or code remains with the user. 
' Complying with all applicable copyright laws is the responsibility of the user. 
'
' Copyright 2013 MYOB Technology Pty Ltd. All rights reserved.

Imports System
Namespace VisualBasicSamples.Common
    Public Enum OperandType
        Equal
        GreaterThan
        GreaterThanOrEqual
        LessThan
        LessThanOrEqual
    End Enum
    Public Class SearchCriteria
        Public Property Field() As String
        Public Property SearchText() As String
        Public Property FieldType() As Type
        Public Property OperandType() As OperandType
    End Class
    Public Enum LogicalOperator
        [and]
        [or]
    End Enum
End Namespace
