puts 'Leap Years Program'
puts 'This program calculates the number of leap years within a range of years.'
puts ''

start = 'What is the starting year?'
ending = 'Great! What is the ending year?'

puts start
first = gets.to_i

puts ending
last = gets.to_i

while first < last
    if (first % 4 == 0 and first % 100 != 0) or (first % 100 == 0 and first % 400 == 0)
    puts first.to_s
end
    first = first + 1
end


