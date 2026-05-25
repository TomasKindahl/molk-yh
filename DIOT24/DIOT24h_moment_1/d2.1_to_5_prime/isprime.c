bool isPrime(long N) {
    if(N < 2) return false;
    if(N == 2) return true;
    if(N % 2 == 0) return false;
    for(long i = 3; i < N; i++)
        if(N % i == 0) return false;
    return true;
}
