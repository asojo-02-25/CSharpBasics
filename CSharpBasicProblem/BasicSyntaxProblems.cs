using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;

namespace CSharpBasics
{
    /// <summary>
    /// C# 学習用の初級問題
    /// 
    /// </summary>
    public static class BasicSyntaxProblems
    {
        public static int Add(int a, int b)
        {
            // 問題 1: 変数と四則演算
            // 2つの整数 a と b を受け取り、その合計を返してください。
            throw new NotImplementedException();
        }

        public static int Remainder(int dividend, int divisor)
        {
            // 問題 2: 剰余演算
            // dividend を divisor で割った余りを返してください。
            throw new NotImplementedException();
        }

        public static double CalculateCircleArea(double radius)
        {
            // 問題 3: double と定数
            // 半径 radius の円の面積を返してください。
            // 円周率には Math.PI を使ってください。
            throw new NotImplementedException();
        }

        public static bool IsEven(int number)
        {
            // 問題 4: bool と条件判定
            // number が偶数なら true、奇数なら false を返してください。
            throw new NotImplementedException();
        }

        public static string GetGrade(int score)
        {
            // 問題 5: if / else if / else
            // score に応じて成績を返してください。
            // 90点以上は "A"、80点以上は "B"、70点以上は "C"、60点以上は "D"、それ未満は "F" を返します。
            // score が 0 未満または 100 より大きい場合は "Invalid" を返してください。
            throw new NotImplementedException();
        }

        public static string GetDayName(int day)
        {
            // 問題 6: switch 式または switch 文
            // day が 1 なら "Monday"、2 なら "Tuesday"、3 なら "Wednesday"、
            // 4 なら "Thursday"、5 なら "Friday"、6 なら "Saturday"、7 なら "Sunday" を返してください。
            // 1 から 7 以外の場合は "Invalid" を返してください。
            throw new NotImplementedException();
        }

        public static int SumFromOneTo(int n)
        {
            // 問題 7: for ループ
            // 1 から n までの整数の合計を返してください。
            // n が 0 以下の場合は 0 を返してください。
            throw new NotImplementedException();
        }

        public static int CountDownByWhile(int start)
        {
            // 問題 8: while ループ
            // start から 1 まで while 文でカウントした回数を返してください。
            // 例: start が 3 の場合、3, 2, 1 の3回なので 3 を返します。
            // start が 0 以下の場合は 0 を返してください。
            throw new NotImplementedException();
        }

        public static int FindMax(int[] numbers)
        {
            // 問題 9: 配列
            // 整数配列 numbers の最大値を返してください。
            // numbers が空の場合は ArgumentException を投げてください。
            throw new NotImplementedException();
        }

        public static int CountPositiveNumbers(int[] numbers)
        {
            // 問題 10: foreach ループ
            // 整数配列 numbers の中にある正の数、つまり 1 以上の数の個数を返してください。
            throw new NotImplementedException();
        }

        public static List<int> DoubleEachNumber(List<int> numbers)
        {
            // 問題 11: List<T>
            // numbers の各要素を2倍にした新しい List<int> を返してください。
            // 引数の List 自体は変更しないでください。
            throw new NotImplementedException();
        }

        public static string RepeatText(string text, int count)
        {
            // 問題 12: 文字列とループ
            // text を count 回連結した文字列を返してください。
            // count が 0 以下の場合は空文字列を返してください。
            throw new NotImplementedException();
        }

        public static string NormalizeName(string firstName, string lastName)
        {
            // 問題 13: 文字列メソッド
            // firstName と lastName の前後の空白を取り除き、"First Last" の形式で返してください。
            // 例: firstName が " Taro "、lastName が " Yamada " の場合は "Taro Yamada" を返します。
            throw new NotImplementedException();
        }

        public static bool ContainsIgnoreCase(string source, string keyword)
        {
            // 問題 14: 大文字小文字を区別しない文字列検索
            // source の中に keyword が含まれていれば true、含まれていなければ false を返してください。
            // 大文字と小文字は区別しないでください。
            throw new NotImplementedException();
        }

        public static Dictionary<string, int> CountWords(IEnumerable<string> words)
        {
            // 問題 15: Dictionary<TKey, TValue>
            // words に含まれる各単語の出現回数を Dictionary<string, int> として返してください。
            // 例: ["apple", "banana", "apple"] の場合、"apple" は 2、"banana" は 1 です。
            throw new NotImplementedException();
        }

        public static double CalculateValidScoreAverage(int[] scores)
        {
            // 問題 16: 難易度 2 - 配列、条件分岐、平均値
            // scores のうち 0 以上 100 以下の値だけを有効な点数として扱い、その平均値を返してください。
            // 無効な点数は平均の計算から除外してください。
            // 有効な点数が1つもない場合は 0 を返してください。
            double sum = 0;
            double count = 0;
            double average = 0;

            foreach (int score in scores)
            {
                if (score < 0 || score > 100) continue;

                sum += score;
                count++;
            }

            if (count == 0)
            {
                return 0;
            }
            else
            {
                average = sum / count;
                return Math.Round(average, 1);
            }
        }

        public static List<string> BuildFizzBuzz(int start, int end)
        {
            // 問題 17: 難易度 2 - ループと複数条件
            // start から end までの整数を順番に見て、次のルールで文字列の List を返してください。
            // 3 と 5 の両方で割り切れる数は "FizzBuzz"、3 で割り切れる数は "Fizz"、
            // 5 で割り切れる数は "Buzz"、それ以外は数値を文字列にしたものを入れてください。
            // start が end より大きい場合は空の List<string>を返してください。
            List<string> list = new List<string>();

            if (start > end) return list;

            for (int i = start; i <= end; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    list.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    list.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    list.Add("Buzz");
                }
                else
                {
                    list.Add(i.ToString());
                }
            }
            return list;
        }

        public static int GetLongestWordLength(string sentence)
        {
            // 問題 18: 難易度 2 - 文字列とループ
            // sentence を半角スペースで区切ったとき、最も長い単語の文字数を返してください。
            // 連続したスペースや前後のスペースは単語として数えません。
            // 単語が1つもない場合は 0 を返してください。
            string[] words = sentence.Split();
            int max = 0;

            foreach (string word in words)
            {
                if(word.Length > max)
                {
                    max = word.Length;
                }
            }
            return max;
        }

        public static bool IsPalindromeIgnoreCaseAndSpaces(string text)
        {
            // 問題 19: 難易度 3 - 文字列の正規化と比較
            // text が回文なら true、そうでなければ false を返してください。
            // 大文字と小文字は区別せず、半角スペースは無視してください。
            // 例: "Never odd or even" はスペースと大文字小文字を無視すると回文なので true です。
            string normalizedtext = text.ToLower().Replace(" ", "");

            for (int i = 0; i < normalizedtext.Length / 2; i++)
            {
                if (normalizedtext[i] != normalizedtext[normalizedtext.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        public static List<int> RotateLeft(List<int> numbers, int count)
        {
            // 問題 20: 難易度 3 - List<T> とインデックス
            // numbers の要素を左に count 個分回転させた新しい List<int> を返してください。
            // 例: [1, 2, 3, 4, 5] を左に 2 回転すると [3, 4, 5, 1, 2] です。
            // count が要素数より大きい場合も正しく回転してください。
            // numbers が空の場合は空の List<int> を返してください。
            // 引数の List 自体は変更しないでください。
            if (numbers.Count() == 0)
            {
                return new List<int>();
            }

            int rotationCount = count % numbers.Count;
            var result = new List<int>(numbers.Count);

            for(int destinationIndex = 0; destinationIndex < numbers.Count; destinationIndex++)
            {
                int sourceIndex = (destinationIndex + rotationCount) % numbers.Count;

                result.Add(numbers[sourceIndex]);
            }

            return result;
        }

        public static Dictionary<string, int> MergeWordCounts(
            Dictionary<string, int> first,
            Dictionary<string, int> second)
        {
            // 問題 21: 難易度 3 - Dictionary<TKey, TValue> の更新
            // 2つの Dictionary<string, int> を結合し、同じキーがある場合は値を合計した新しい Dictionary を返してください。
            // first と second 自体は変更しないでください。
            Dictionary<string, int> result = new Dictionary<string, int>();

            foreach (KeyValuePair<string, int> pair in first)
            {
                if (second.ContainsKey(pair.Key))
                {
                    result[pair.Key] = pair.Value + second[pair.Key]; 
                }
                else
                {
                    result[pair.Key] = pair.Value;
                }
            }

            foreach(KeyValuePair<string, int> pair in second)
            {
                if (!first.ContainsKey(pair.Key))
                {
                    result[pair.Key] = pair.Value;
                }
            }

            return result;                    
        }

        public static string FindMostFrequentWord(IEnumerable<string> words)
        {
            // 問題 22: 難易度 4 - 正規化、Dictionary、同率時の扱い
            // words に含まれる単語のうち、最も出現回数が多い単語を小文字で返してください。
            // 比較では大文字と小文字を区別せず、各単語の前後の空白は取り除いてください。
            // 空文字列になった単語は無視してください。
            // 最多の単語が複数ある場合は、最初にその最多回数へ到達した単語を返してください。
            // 有効な単語が1つもない場合は空文字列を返してください。
            Dictionary<string, int> count = new Dictionary<string, int>();
            int max = 0;
            string maxword = string.Empty;

            foreach (string word in words)
            {
                string lowerword = word.Trim().ToLowerInvariant();

                if (!count.ContainsKey(lowerword))
                {
                    count[lowerword] = 1;
                }
                else
                {
                    count[lowerword] += 1;
                }

                if (count[lowerword] > max)
                {
                    max = count[lowerword];
                    maxword = lowerword;
                }
            }

            return maxword;
        }

        public static bool AreParenthesesBalanced(string text)
        {
            // 問題 23: 難易度 4 - 状態を持つ走査
            // text に含まれる丸括弧 '(' と ')' の対応が正しければ true、正しくなければ false を返してください。
            // 丸括弧以外の文字は無視してください。
            // 途中で閉じ括弧が多くなる場合、または最後に開き括弧が残る場合は false です。
            int leftcount = 0, rightcount = 0;
            foreach (char c in text)
            {
                if(c == '(')
                {
                    leftcount += 1;
                }
                else if (c == ')')
                {
                    rightcount += 1;
                }

                if (leftcount < rightcount)
                {
                    return false;
                }
            }

            if (leftcount != rightcount)
            {
                return false;
            }

            return true;
        }

        public static List<int> CalculateRunningTotals(int[] numbers)
        {
            // 問題 24: 難易度 4 - 累積値
            // numbers の各位置までの累積和を List<int> として返してください。
            // 例: [3, -1, 4] の場合、[3, 2, 6] を返します。
            // numbers が空の場合は空の List<int> を返してください。
            List<int> result = new List<int>();
            int sum = 0;

            foreach (int num in numbers)
            {
                sum += num;
                result.Add(sum);
            }

            return result;
        }

        public static Dictionary<string, List<int>> GroupNumbersByParity(int[] numbers)
        {
            // 問題 25: 難易度 4 - Dictionary と List の組み合わせ
            // numbers を偶数と奇数に分け、"Even" と "Odd" をキーにした Dictionary<string, List<int>> を返してください。
            // 各 List では元の配列に出てきた順序を保ってください。
            // 偶数または奇数が1つもない場合でも、"Even" と "Odd" の両方のキーを必ず含めてください。
            Dictionary<string, List<int>> result = new Dictionary<string, List<int>>()
            {
                ["Even"] = new List<int>(),
                ["Odd"] = new List<int>()
            };

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    result["Even"].Add(num);
                }
                else
                {
                    result["Odd"].Add(num);
                }
            }

            return result;
        }
    }
}