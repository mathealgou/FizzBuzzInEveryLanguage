import time
start_time = time.time()

def fizz_buzz():
    for i in range(0, 1000000):
        if i % 3 == 0 and i % 5 == 0:
            print('FizzBuzz')
        elif i % 3 == 0:
            print('Fizz')
        elif i % 5 == 0:
            print('Buzz')
        else:
            print(i)

fizz_buzz()
print("--- %s seconds ---" % (time.time() - start_time))