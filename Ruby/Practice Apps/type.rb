puts
puts 'Type Repeater Program'
puts 'This program repeats back what you type in alphabetical order.'
puts

puts 'Please type whatever you would like.'
puts 'I only ask that you type one word per line and '
puts 'continue until you type end on an empty line.'
puts

response = ''
array = []

while response != 'end'
        array.push response
        puts array.sort
        response = gets.chomp

end

 