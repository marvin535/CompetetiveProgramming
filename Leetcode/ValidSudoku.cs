public class Solution {
    public bool IsValidSudoku(char[][] board) {
        // HashSets para ma store yung digits kada row, column, and 3x3 box
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] cols = new HashSet<char>[9];
        HashSet<char>[] boxes = new HashSet<char>[9];

        for (int i = 0; i < 9; i++) {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        // Traverse each cell in the 9x9 board
        for (int r = 0; r < 9; r++) {
            for (int c = 0; c < 9; c++) {
                char num = board[r][c];

                // Skip empty cells
                if (num == '.') continue;

                // Check row
                if (rows[r].Contains(num)) return false;
                rows[r].Add(num);

                // Check column
                if (cols[c].Contains(num)) return false;
                cols[c].Add(num);

                // Check 3x3 sub-box
                int boxIndex = (r / 3) * 3 + c / 3;
                if (boxes[boxIndex].Contains(num)) return false;
                boxes[boxIndex].Add(num);
            }
        }

        return true;
    }
}
