'This is an example of Spirit code
'Two touch sensors control two motors
DeleteAllTasks
BeginOfTask 1
    SetVar 1, Number, 1 	'variable 1 gets value 1
    Loop Number, 0 		'eternal loop
        If SENSOR, 0, EQUAL_TO, Number, 0
            On (motor_a)
        Else
            Off (motor_a)
        EndIf
    EndLoop
EndOfTask
pausedownload
BeginOfTask 2
    SetVar 1, Number, 1 	'variable 1 gets value 1
    Loop Number, 0 		'eternal loop
        If SENSOR, 2, EQUAL_TO, Number, 0
            On (motor_c)
        Else
            Off (motor_c)
        EndIf
    EndLoop
EndOfTask
pausedownload
BeginOfTask 0
    StartTask 1
    StartTask 2
EndOfTask
