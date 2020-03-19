'random tones
DeleteAllTasks
BeginOfTask 0
    SetVar 1, Number, 1 'variable 1 gets value 1
    Loop Number, 0 'eternal loop
        SetVar 2, RANDOM, 3 'random integers van 0 tot n
        If VARIABLE, 2, EQUAL_TO, Number, 0
            PlayTone 400, 1
        EndIf
        If VARIABLE, 2, EQUAL_TO, Number, 1
            PlayTone 800, 1
        EndIf
        If VARIABLE, 2, EQUAL_TO, Number, 2
            PlayTone 1600, 1
        EndIf
        If VARIABLE, 2, EQUAL_TO, Number, 3
            PlayTone 3200, 1
        EndIf
        Wait RANDOM, 100
    EndLoop
EndOfTask

