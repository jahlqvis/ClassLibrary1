Option Explicit

Sub Test()
    
    Dim obj As ClassLibrary1.Class1
    Set obj = New ClassLibrary1.Class1
    
    Dim vect(0 To 4) As Double
    vect(0) = 1#
    vect(1) = 6#
    vect(2) = 5#
    vect(3) = 2#
    vect(4) = 3#
    
    Dim res As Double
    
    res = obj.SumVector(vect)

End Sub