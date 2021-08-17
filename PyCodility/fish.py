def solution(A, B):
    fishCount = 0
    goingDownstream = []

    for i in range(len(A)):
        if B[i] == 0:
            while len(goingDownstream) != 0:
                if goingDownstream[-1] > A[i]:
                    break
                else:
                    goingDownstream.pop()
            else:
                fishCount += 1
        else:
            goingDownstream.append(A[i])

    return fishCount + len(goingDownstream)
