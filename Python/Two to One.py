# Take 2 strings s1 and s2 including only letters from ato z. 
# Return a new sorted string, the longest possible, containing distinct letters,

def longest(s1, s2):
    return ''.join(sorted(set(s1 + s2)))