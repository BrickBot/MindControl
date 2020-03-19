'Random drift of three motors
.DeleteAllTasks
.BeginOfTask 1 'controls motor A
    .SetVar 1, Number, 1 'variable 1 gets value 1
	.Loop Number, 0 'eternal loop
        .SetVar 2, RANDOM, 1
        .If VARIABLE, 2, GREATER_THAN, Number, 0
            .SetFwd motor_a
        .Else
            .SetRwd motor_a
        .EndIf
        .SetPower motor_a, RANDOM, 2
        .On motor_a
        .Wait Number, 100
        .Off motor_a
    .EndLoop
.EndOfTask
PauseDownload 1
.BeginOfTask 2 'controls motor B
    .SetVar 3, Number, 1 'variable 1 gets value 1
    .Loop Number, 0 'eternal loop
        .SetVar 4, RANDOM, 1
        .If VARIABLE, 4, GREATER_THAN, Number, 0
            .SetFwd motor_b
        .Else
            .SetRwd motor_b
        .EndIf
        .SetPower motor_b, RANDOM, 2
        .On motor_b
        .Wait Number, 100
        .Off motor_b
    .EndLoop
.EndOfTask
PauseDownload 1
.BeginOfTask 3 'controls motor C
    .SetVar 5, Number, 1 'variable 1 gets value 1
    .Loop Number, 0 'eternal loop
        .SetVar 6, RANDOM, 1
        .If VARIABLE, 6, GREATER_THAN, Number, 0
            .SetFwd motor_c
        .Else
            .SetRwd motor_c
        .EndIf
        .SetPower motor_c, RANDOM, 2
        .On motor_c
        .Wait RANDOM, 100
        .Off motor_c
    .EndLoop
.EndOfTask
PauseDownload 1
.BeginOfTask 0
    .StartTask 1
    .StartTask 2
    .StartTask 3
.EndOfTask