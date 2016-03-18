puts 'Hello there, and what\'s your first name?'
first = gets.chomp

puts 'Thank you ' + first.capitalize + '.  ' 'And what\'s your middle name?'
middle = gets.chomp

puts 'Great! What\'s your last name please?'
last = gets.chomp
puts ''

if (first == 'Kent' or first == 'Michael')
    puts 'Wait! Not the one and only ' + first + '?! You don\'t say!!'
else puts 'Your name is ' + first.capitalize + ' '+ middle.capitalize + ' ' + last.capitalize + '? What a lovely name!'
end

puts ''
puts 'Pleased to meet you, ' + first.capitalize + ' '+ middle.capitalize + ' '+ last.capitalize + '.  :)'
puts ''
puts first.capitalize + ' I hope you don\'t mind but I made some purchases in your name.'

puts ''

puts first.capitalize + ', what is your favorite number?'

num1 = gets.chomp
num2 = num1.to_i + 1
num3 = first.length.to_i + middle.length.to_i + last.length.to_i 

puts ''

puts 'Your favorite number is ' + num1 + '?' + ' Well, ' + first.capitalize + ' that\'s a nice number.'

puts ''

puts 'However, might I recommend ' + num2.to_s + '?'

puts ''

puts 'You see ' + first.capitalize + ', ' + num2.to_s + ' is bigger, better and even sexier.'

puts''
puts 'By the way, did you know there are ' + num3.to_s + ' characters in your full name, ' + first.capitalize + '?'
puts''
puts 'Thanks for the chit chat.  Have a great day ' + first.capitalize + '!'

